using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class CanvasButtonScript : MonoBehaviour
{
    public void OnHover()
    {
        DOTween.To(()=> GetComponent<Image>().color, x=> GetComponent<Image>().color = x, Color.white, 1);
    }

    public void OnNotHover()
    {
        DOTween.To(()=> GetComponent<Image>().color, x=> GetComponent<Image>().color = x, new Color(0.56f,0.56f,0.56f,1), 1);
    }
}
