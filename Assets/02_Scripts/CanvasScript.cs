using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{
   public RectTransform canvasElement;
    GameObject targetObject;
   public  Camera mainCamera;

    private void Update()
    {
        CheckCollision();
    }

    void CheckCollision()
    {
        // Convertir la posición del canvasElement a coordenadas de pantalla
        Vector3 screenPos = RectTransformUtility.WorldToScreenPoint(mainCamera, canvasElement.position);

        // Lanzar el rayo desde la cámara a la posición del canvas
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

}
