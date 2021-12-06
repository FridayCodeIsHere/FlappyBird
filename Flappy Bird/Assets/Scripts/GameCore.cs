using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameCore : MonoBehaviour
{

    private List<int> _scores;
    public static GameCore singleton { get; private set; }
    public float _speedGame { get; private set; } = 1f;
    public UnityEvent gameStart;
    public UnityEvent gameOver;

    
    
    private void Awake()
    {
        _scores = new List<int>();
        if (singleton == null)
        {
            singleton = this;
            DontDestroyOnLoad(this.gameObject);
        }
        Destroy(this.gameObject);
    }

    public void AddScore(int score)
    {
        _scores.Add(score);
    }

}
