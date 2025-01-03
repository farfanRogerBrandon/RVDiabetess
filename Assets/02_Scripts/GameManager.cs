using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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


    public float FruitsTaked = 0;
          
    public float maxFruitsTaked = 15;
          
    public float maxFatFood = 3;
    public float fatFood = 0;


    public float fruitsThatCanPass = 7;
    public float fruitsPassed = 0;


    public Image lifeBar;
    public Image fastFoodBar;
    public Image fruitsTakedBar;


    public GameObject partEaten;
    public GameObject partTaked;

    public AudioClip partEatenAC;
    public AudioClip partTakenAC;


    public int count = 0;
    private void Awake()
    {
       
            instance = this;
          
      
    }
    void Start()
    {
        UpdateLifeBars();
    }
    void UpdateLifeBars()
    {
        lifeBar.fillAmount = (fruitsThatCanPass-fruitsPassed) / fruitsThatCanPass ;

        fastFoodBar.fillAmount = fatFood / maxFatFood;
        fruitsTakedBar.fillAmount = FruitsTaked / maxFruitsTaked;


    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void fruitPassed()
    {
       fruitsPassed++;
        UpdateLifeBars();

        if (fruitsPassed >= fruitsThatCanPass)
        {
            int n = Random.Range(1, 4);
            
            SceneManager.LoadScene("GAMEOVER");
        }


    }
    public void fruitEated()
    {
        FruitsTaked ++;
        UpdateLifeBars();

        if (FruitsTaked >= maxFruitsTaked)
        {
            //GANAR
            int n = Random.Range(1, 4);
            SceneManager.LoadScene("Cooking" + n);

        }
    }

    public void fatFoodEated()
    {
        fatFood++;
        UpdateLifeBars();

        if (fatFood >= maxFatFood)
        {
            SceneManager.LoadScene("GAMEOVER");
        }
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
