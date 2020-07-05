using System;
using DG.Tweening;
using TMPro;
using UnityEngine;

internal class DropText : MonoBehaviour
{
    public TextMeshProUGUI NameText;
    [SerializeField] private float fadeTime;
    [SerializeField] private float moveTime;
    [SerializeField] private float endHeight;
    


    private void Start()
    {
        NameText.DOFade(0, fadeTime).OnComplete(() => gameObject.SetActive(false));
        NameText.rectTransform.DOAnchorPosY(endHeight, fadeTime);
    }
}