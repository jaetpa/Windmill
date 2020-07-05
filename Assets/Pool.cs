using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Pool : MonoBehaviour
{
    [SerializeField] private Ball ballPrefab;
    [SerializeField] private int poolSize;
    [SerializeField] private List<Sprite> avatars;

    private List<Ball> Balls;

    // Start is called before the first frame update
    void Start()
    {
        poolSize = avatars.Count;
        Balls = new List<Ball>();
        for (int i = 0; i < poolSize; i++)
        {
            var b = Instantiate(ballPrefab, this.transform);
            b.gameObject.SetActive(false);
            Balls.Add(b);
            b.ballPool = this;
            var index = Random.Range(0, avatars.Count);
            var avatar = avatars[index];
            avatars.RemoveAt(index);
            b.SpriteRenderer.sprite = avatar;
        }
    }

    public Ball GetBall()
    {
        var eligible =  Balls.Where(b => b.gameObject.activeInHierarchy == false).ToList();
        if (eligible.Count == 0)
        {
            return null;
        }
        var index = Random.Range(0, eligible.Count);
        return eligible[index];
    }

    public void RepoolBall(Ball b)
    {
        b.gameObject.SetActive(false);
        b.transform.SetParent(this.transform);
        b.transform.position = transform.position;
    }
}