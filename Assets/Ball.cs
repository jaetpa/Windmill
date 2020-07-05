using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Pool ballPool;
    public SpriteRenderer SpriteRenderer;
    [SerializeField] private TextMeshPro NameTag;

    public string Username
    {
        get => NameTag.text;
    }
    private void OnBecameInvisible()
    {
        ballPool.RepoolBall(this);
    }

    private void OnEnable()
    {
        if (SpriteRenderer.sprite == null)
        {
            return;
        }
        NameTag.gameObject.SetActive(true);
        NameTag.text = SpriteRenderer.sprite.name.Substring(7);
        StartCoroutine(DisableNameTag());
    }

    IEnumerator DisableNameTag()
    {
        yield return new WaitForSeconds(2f);
        NameTag.gameObject.SetActive(false);
    }
}
