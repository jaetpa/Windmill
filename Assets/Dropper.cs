using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{

    [SerializeField] private float x_var;
    [SerializeField] private float minDelay;
    [SerializeField] private float maxDelay;
    [SerializeField] private Pool ballPool;

    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DropBalls());
    }

    private IEnumerator DropBalls()
    {
        yield return new WaitForSeconds(Random.Range(minDelay, maxDelay));

        while (true)
        {
            var ball = ballPool.GetBall();
            if (ball == null)
            {
                yield break;
            }
            else
            {
                yield return new WaitForSeconds(Random.Range(minDelay, maxDelay));
                ball.transform.position = transform.position + (Vector3.right * Random.Range(-x_var, x_var));
                ball.gameObject.SetActive(true);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
