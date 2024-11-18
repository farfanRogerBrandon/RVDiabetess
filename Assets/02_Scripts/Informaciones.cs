using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Informaciones : MonoBehaviour
{
    [SerializeField] private GameObject tarjeta;
    [SerializeField] private GameObject mensaje;
    [SerializeField] private GameObject restart;
    [SerializeField] private GameObject exit;
    [SerializeField] private GameObject atras;
    [SerializeField] private GameObject decoracion1;
    [SerializeField] private GameObject decoracion2;

    private void Start()
    {
        LeanTween.moveX(tarjeta.GetComponent<RectTransform>(), 593, 1f).setEase(LeanTweenType.easeInOutBack);
        LeanTween.moveX(mensaje.GetComponent<RectTransform>(), -418, 1f).setEase(LeanTweenType.easeInOutBack);
        LeanTween.moveX(restart.GetComponent<RectTransform>(), -680, 1f).setEase(LeanTweenType.easeInOutBack);
        LeanTween.moveX(atras.GetComponent<RectTransform>(), -424, 1f).setEase(LeanTweenType.easeInOutBack);
        LeanTween.moveX(exit.GetComponent<RectTransform>(), -172, 1f).setEase(LeanTweenType.easeInOutBack);

        LeanTween.moveY(decoracion1.GetComponent<RectTransform>(), 551, 1f).setDelay(1f).setEase(LeanTweenType.easeInOutCirc);
        LeanTween.moveY(decoracion2.GetComponent<RectTransform>(), -533, 1f).setDelay(1f).setEase(LeanTweenType.easeInOutCirc);
        
    }
}
