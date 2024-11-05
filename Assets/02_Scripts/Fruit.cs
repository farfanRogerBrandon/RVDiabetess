using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5f;
    public float theValue = 5f;
    public float timeToDIe = 6f;



    public float maxTimeToBePOinted = 2f;
    public float timeBeingPointed = 0f;



    public bool isBeingAnimated = false;
    public bool isBeingTaked = false;   

    public Animator animator;

    public List<ClipStatus> clipStatuses = new List<ClipStatus>();
    public List<AudioClip> audioClips = new List<AudioClip>();




    public string fruitName = "Ciruela";
    public string isRecommended = "Recomendado";


    void Start()
    {
        Destroy(gameObject, timeToDIe);
        foreach (var item in audioClips)
        {
            clipStatuses.Add(new ClipStatus() { ac = item });
                    
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!isBeingTaked)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

        }
    }


    private void OnMouseDown()
    {
        Destroy(gameObject);
    }



    public void PointingGG()
    {
        if (!isBeingTaked)
        {
            isBeingTaked=true;
            GameManager.instance.selectedFruit = this;
            GameManager.instance.SetFruitData();

            AudioManager.instance.PlaySFX(audioClips[Random.Range(0,audioClips.Count)]);    
        }
        if (!isBeingAnimated) 
        {
            isBeingAnimated = true;
            animator.SetTrigger("Take");
        }
        timeBeingPointed+= Time.deltaTime;
        if (timeBeingPointed >= maxTimeToBePOinted)
        {
            Destroy(gameObject);
            GameManager.instance.DontSetFrui();
        }
    }


    public void DontTake()
    {
        Debug.Log("Hola dont take");
        animator.SetTrigger("Idle");
        isBeingAnimated= false;
        isBeingTaked = false ;
        GameManager.instance.selectedFruit = null;




    }
}

public enum FruitType
{
    Health, 
    UnHealth
}
