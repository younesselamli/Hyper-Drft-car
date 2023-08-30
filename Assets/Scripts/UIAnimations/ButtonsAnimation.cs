using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ButtonsAnimation : MonoBehaviour
{
    public List<RectTransform> Buttons;
    public List<RectTransform> logo;
    [SerializeField] Ease expandEase;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(IE_Display(0.3f, 0.1f));
        StartCoroutine(IE_Display2(0.3f, 0.1f));
    }

    IEnumerator IE_Display(float delayStart,float delayDisplay)
    {
        
        yield return new WaitForSeconds(delayStart);
        for (int i = 0; i < Buttons.Count; i++)
        {
            Buttons[i].DOMoveY(100, 0.20f).SetEase(expandEase);
            yield return new WaitForSeconds(delayDisplay);
        }
        
    }
    IEnumerator IE_Display2(float delayStart,float delayDisplay)
    {
        yield return new WaitForSeconds(delayStart);
        for (int i = 0; i < logo.Count; i++)
        {
            logo[i].DOMoveY(1050, 1f).SetEase(expandEase);
            yield return new WaitForSeconds(delayDisplay);
        }
        
    }

}
