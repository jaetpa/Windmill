using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private int score;
    [Space] [SerializeField] private float scale = 1;
    [SerializeField] private float duration = 1;
    [SerializeField] private int vibrato = 10;
    [SerializeField] private float elasticity = 1;


    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
    }

    public void UpdateScore(int newScore)
    {
        score = newScore;
        scoreText.text = score.ToString();
        //scoreText.rectTransform.DOPunchScale(Vector3.one * scale, duration, vibrato, elasticity);
    }

    public void AddScore()
    {
        UpdateScore(score + 5);
    }

    public void RemoveScore()
    {
        UpdateScore(score - 5);
    }
}