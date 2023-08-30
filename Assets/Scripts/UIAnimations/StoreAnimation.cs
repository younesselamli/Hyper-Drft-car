using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class StoreAnimation : MonoBehaviour
{
    public float fadeTime = 1;
    public float fadeTimeItems = 2;
    public float delayTime = .2f;
    public CanvasGroup canvasGroup;
    public RectTransform rectTransform;
    [SerializeField] Ease animationIn;
    [SerializeField] Ease animationOut;
    public List<GameObject> items = new List<GameObject>();

    public void Start()
    {
        canvasGroup.DOFade(0, 0.00f);
        rectTransform.transform.localPosition = new Vector3(0,-2000f, 0);
    }

    public void PanelFadeIn()
    {
        canvasGroup.alpha = 0f;
        rectTransform.transform.localPosition = new Vector3(0, -2000f, 0);
        rectTransform.DOAnchorPos(new Vector2(0f, 0f),fadeTime,false).SetEase(animationIn);
        canvasGroup.DOFade(1, fadeTime);
        StartCoroutine(ItemAnimation());
    }
    public void PanelFadeOut()
    {
        canvasGroup.alpha = 1f;
        rectTransform.transform.localPosition = new Vector3(0, 0f, 0);
        rectTransform.DOAnchorPos(new Vector2(0f, 0-2000f), fadeTime, false).SetEase(animationOut);
        canvasGroup.DOFade(0, fadeTime);
    }
    IEnumerator ItemAnimation()
    {
        foreach (var item in items)
        {
            item.transform.localScale = Vector3.zero;
        }
        foreach (var item in items)
        {
            
            item.transform.DOScale(1f, fadeTimeItems).SetEase(Ease.OutBounce);
            yield return new WaitForSeconds(delayTime);
        }
    }
}
