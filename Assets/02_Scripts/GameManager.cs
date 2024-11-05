using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

    public static GameManager instance;

    public  Fruit selectedFruit;


    public Text fruitTitleTxt;
    public Text isRecommendedTxt;


    public GameObject gmTitle;
    public GameObject gmIsRecommended;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject );
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void SetFruitData()
    {
        gmTitle.SetActive(true);
        gmIsRecommended.SetActive(true);

        fruitTitleTxt.text = selectedFruit.fruitName;
        isRecommendedTxt.text = selectedFruit.isRecommended;
    }
    public void DontSetFrui()
    {
        fruitTitleTxt.text = "";
        isRecommendedTxt.text = "";
        gmTitle.SetActive(false);
        gmIsRecommended.SetActive(false);
       

    }


}
