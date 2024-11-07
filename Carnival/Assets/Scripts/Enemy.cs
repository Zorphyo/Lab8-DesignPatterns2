using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy : MonoBehaviour, ISubject
{
    public float enemySize;
    public int pointValue;
    public Color enemyColor;
    SpriteRenderer sr;

    public int State {get; set;} = -0;
    private List<IObserver> _observers = new List<IObserver>();

    // Start is called before the first frame update
    void Start()
    {
        Attach(GameObject.Find("ScoreManager").GetComponent<ScoreManager>());

        transform.localScale *= enemySize;

        sr = GetComponent<SpriteRenderer>();
        sr.color = enemyColor;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.UpdateObserver(this);
        }
    }

    public void Add(float size)
    {
        enemySize = size;
    }

    public void Add(int points)
    {
        pointValue = points;
    }

    public void Add(Color color)
    {
        enemyColor = color;
    }
}
