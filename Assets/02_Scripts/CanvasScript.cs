using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.HID;
using UnityEngine.SceneManagement;

public class CanvasScript : MonoBehaviour
{
   public RectTransform canvasElement;
    GameObject targetObject;
   public  Camera mainCamera;


    public GameObject fruit;

    public bool isShopping = true;
    public bool isMenu = false;

    public bool isSelecting = false;

    public GameObject squrePoint;

    public GameObject btnOk;
    public GameObject btnOkGM;

    private void Update()
    {
        if (isShopping)
        {
            CheckCollision();
        }
        else if (isMenu)
        {
            CheckCollision3();
        }
        else
        {
            CheckCollision2();
            ///*Debug.Log("HOLA");
            //Vector3 screenPos = RectTransformUtility.WorldToScreenPoint(mainCamera, canvasElement.position);
            //Vector3 worldPos = mainCamera.ScreenToWorldPoint(new Vector3(screenPos.x, screenPos.y, canvasElement.position.z - mainCamera.transform.position.z));
            //fruit.transform.position = new Vector3(worldPos.x, worldPos.y, fruit.transform.position.z);
            //var position = mainCamera.WorldToScreenPoint(.transform.position);*/
            //fruit.transform.position = squrePoint.transform.position;
        }
    }

    void CheckCollision()
    {
        Vector3 screenPos = RectTransformUtility.WorldToScreenPoint(mainCamera, canvasElement.position);

        Ray ray = mainCamera.ScreenPointToRay(screenPos);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            if (hit.collider.gameObject.CompareTag("Fruit"))
            {
                if (GameManager.instance.selectedFruit != null)
                {
                    Fruit f = hit.collider.gameObject.GetComponent<Fruit>();
                    if (GameManager.instance.selectedFruit == f) 
                    { 
                          f.PointingGG();

                    }
                }
                else
                {
                    Fruit f = hit.collider.gameObject.GetComponent<Fruit>();
                    f.PointingGG();


                }


            }
            else
            {
                if (GameManager.instance.selectedFruit != null)
                {
                    Debug.Log("HOla 1");
                    GameManager.instance.DontSetFrui();

                    GameManager.instance.selectedFruit.DontTake();

                }

            }
        }
        else {
            if (GameManager.instance.selectedFruit != null)
            {
                Debug.Log("HOla 2");

                GameManager.instance.DontSetFrui();

                GameManager.instance.selectedFruit.DontTake();
             

            }

        }
    }


    public float moveSpeed = 5f;

    void CheckCollision2()
    {
        Vector3 screenPos = RectTransformUtility.WorldToScreenPoint(mainCamera, canvasElement.position);

        Ray ray = mainCamera.ScreenPointToRay(screenPos);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            if (hit.collider.gameObject.CompareTag("Fruit"))
            {
                if (GameManager.instance.selectedFruit != null)
                {
                    Fruit f = hit.collider.gameObject.GetComponent<Fruit>();
                    if (GameManager.instance.selectedFruit == f)
                    {
                        f.PointingGG2();

                    }
                }
                else
                {
                    Fruit f = hit.collider.gameObject.GetComponent<Fruit>();
                    f.PointingGG2();


                }


            }
            else
            {
                if (GameManager.instance.selectedFruit != null)
                {
                    Debug.Log("HOla 1");
                  //  GameManager.instance.DontSetFrui();

                    GameManager.instance.selectedFruit.DontTake();

                }

            }
        }
        else
        {
            if (GameManager.instance.selectedFruit != null)
            {
                Debug.Log("HOla 2");

                GameManager.instance.DontSetFrui();

                GameManager.instance.selectedFruit.DontTake();


            }

        }
    }
    void CheckCollision3()
    {
        Vector3 screenPos = RectTransformUtility.WorldToScreenPoint(mainCamera, canvasElement.position);

        Ray ray = mainCamera.ScreenPointToRay(screenPos);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            if (hit.collider.gameObject.CompareTag("btnCanvas"))
            {

                if (!isSelecting)
                {
                    btnOk.SetActive(true);
                    btnOkGM.SetActive(true);

                    isSelecting = true;
                } 

            }
            if (hit.collider.gameObject.CompareTag(btnOk.tag))
            {
                SceneManager.LoadScene(1);

            }
            else
            {
                if (isSelecting)
                {
                    isSelecting = false;
                }
            }
          
        }
        else
        {
            if (isSelecting)
            {
                isSelecting = false;
            }

        }
    }

}
