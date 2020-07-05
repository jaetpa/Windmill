using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBox : MonoBehaviour
{
    [SerializeField] private TextSpawner textSpawner;
    [SerializeField] private Transform textTarget;
    [SerializeField] private ScoreText _scoreText;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Ball>() is Ball b)
        {
            textSpawner.SpawnDropText(b.Username, textTarget);
        }

        if (name.ToUpper().Contains("LAME"))
        {
            _scoreText.RemoveScore();
        }
        else
        {
            _scoreText.AddScore();
        }
    }
}