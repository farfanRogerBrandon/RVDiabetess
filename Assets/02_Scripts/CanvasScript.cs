using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.HID;

public class CanvasScript : MonoBehaviour
{
   public RectTransform canvasElement;
    GameObject targetObject;
   public  Camera mainCamera;


    public GameObject fruit;

    public bool isShopping = true;


    public GameObject squrePoint;
    private void Update()
    {
        if (isShopping)
        {
            CheckCollision();
        }
        else
        {
            // CheckCollision2();
            /*Debug.Log("HOLA");
            Vector3 screenPos = RectTransformUtility.WorldToScreenPoint(mainCamera, canvasElement.position);
            Vector3 worldPos = mainCamera.ScreenToWorldPoint(new Vector3(screenPos.x, screenPos.y, canvasElement.position.z - mainCamera.transform.position.z));

            fruit.transform.position = new Vector3(worldPos.x, worldPos.y, fruit.transform.position.z);

            var position = mainCamera.WorldToScreenPoint(.transform.position);*/
           
            fruit.transform.position = squrePoint.transform.position;



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
                        
                        f.transform.position = Vector3.MoveTowards(f.transform.position, screenPos, moveSpeed * Time.deltaTime);
                        f.PointingGG();
                    }
                }
                else
                {
                    Fruit f = hit.collider.gameObject.GetComponent<Fruit>();
                    f.transform.position = Vector3.MoveTowards(f.transform.position, screenPos, moveSpeed * Time.deltaTime);
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


}
