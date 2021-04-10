using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Rendering.PostProcessing;
public class CanvasButtons : MonoBehaviour
{
    private List<string> langStr = new List<string>{"kz","ru","en"};
    public PostProcessVolume volume;
    Vignette _vignette;
    private void Start() {
        volume.profile.TryGetSettings(out _vignette);    
    }
    public void OpenScene(){
        StartCoroutine(ShowHide());
    }
    private IEnumerator ShowHide(){
        DOTween.To(()=> _vignette.opacity.value, x=> _vignette.opacity.value= x, 1f, 1);
        yield return new WaitForSeconds(1f);
        DOTween.To(()=> _vignette.opacity.value, x=> _vignette.opacity.value= x, 0f, 1);
        this.gameObject.SetActive(false);
    }
}
