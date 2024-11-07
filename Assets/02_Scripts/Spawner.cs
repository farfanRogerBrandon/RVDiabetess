using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update

    public List<GameObject> fruits = new List<GameObject>();

    public Transform minPointX;
    public Transform maxPointX;

    public float TimeBtwAppears = 3f;
    public float currentTime = 0;   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime < TimeBtwAppears) 
        {
            currentTime += Time.deltaTime;

        }
        else
        {
            currentTime = 0;

            float x = Random.Range(minPointX.position.x, maxPointX.position.x);

            Instantiate(fruits[Random.Range(0, fruits.Count)], new Vector3(x, minPointX.position.y, minPointX.position.z), Quaternion.Euler(0,180,0));
        }
    }
}
