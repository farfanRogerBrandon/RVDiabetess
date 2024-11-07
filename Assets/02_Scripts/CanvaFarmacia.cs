using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvaFarmacia : MonoBehaviour
{
    [SerializeField] private GameObject tarjeta;
    [SerializeField] private GameObject tarjeta2;
    [SerializeField] private GameObject tarjeta3;
    [SerializeField] private GameObject imagen1;
    [SerializeField] private GameObject imagen2;
    [SerializeField] private GameObject imagen3;
    [SerializeField] private GameObject decoracion1;
    [SerializeField] private GameObject decoracion2;
    [SerializeField] private GameObject decoracion3;
    [SerializeField] private GameObject decoracion4;
    [SerializeField] private GameObject texto1;
    [SerializeField] private GameObject texto2;
    [SerializeField] private GameObject texto3;

    private void Start()
    {
        LeanTween.moveX(tarjeta.GetComponent<RectTransform>(), 490, 1f).setEase(LeanTweenType.easeInOutBack);
        LeanTween.moveX(tarjeta2.GetComponent<RectTransform>(), 17, 1f).setEase(LeanTweenType.easeInOutBack);
        LeanTween.moveX(tarjeta3.GetComponent<RectTransform>(), -478, 1f).setEase(LeanTweenType.easeInOutBack);
        LeanTween.moveX(imagen1.GetComponent<RectTransform>(), 491, 1f).setDelay(1f).setEase(LeanTweenType.easeInOutBack);
        LeanTween.moveX(imagen2.GetComponent<RectTransform>(), 20, 1f).setDelay(1f).setEase(LeanTweenType.easeInOutBack);
        LeanTween.moveX(imagen3.GetComponent<RectTransform>(), -485, 1f).setDelay(1f).setEase(LeanTweenType.easeInOutCirc);
        LeanTween.moveY(decoracion1.GetComponent<RectTransform>(), 575, 1f).setDelay(1f).setEase(LeanTweenType.easeInOutCirc);
        LeanTween.moveY(decoracion2.GetComponent<RectTransform>(), -578, 1f).setDelay(1f).setEase(LeanTweenType.easeInOutCirc);
        LeanTween.moveX(decoracion3.GetComponent<RectTransform>(), 767, 1f).setDelay(1f).setEase(LeanTweenType.easeInOutCirc);
        LeanTween.moveX(decoracion4.GetComponent<RectTransform>(), -825, 1f).setDelay(1f).setEase(LeanTweenType.easeInOutCirc);
        LeanTween.moveX(texto1.GetComponent<RectTransform>(), 490, 1f).setDelay(1f).setEase(LeanTweenType.easeInOutCirc);
        LeanTween.moveX(texto2.GetComponent<RectTransform>(), 17, 1f).setDelay(1f).setEase(LeanTweenType.easeInOutCirc);
        LeanTween.moveX(texto3.GetComponent<RectTransform>(), -478, 1f).setDelay(1f).setEase(LeanTweenType.easeInOutCirc);
    }
}
