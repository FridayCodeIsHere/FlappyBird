using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameCore : MonoBehaviour
{
    public static GameCore singleton { get; private set; }
    public float _speedGame { get; private set; } = 1f;
    public UnityEvent gameStart;
    public UnityEvent gameOver;

    
    
    private void Awake()
    {
        if (singleton == null)
        {
            singleton = this;
            DontDestroyOnLoad(this.gameObject);
        }
        Destroy(this.gameObject);
    }

}
