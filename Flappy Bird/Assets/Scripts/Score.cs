using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class Score : MonoBehaviour
{
    public static Score singleton { get; private set; }
    private Text _scoreText;
    private int _score = 0;

    private void Awake()
    {
        if (singleton == null)
        {
            singleton = this;
            DontDestroyOnLoad(this.gameObject);
            return;
        }
        Destroy(this.gameObject);
    }
    private void Start()
    {
        _scoreText = GetComponent<Text>();
        InitializationScore();
    }

    private void InitializationScore()
    {
        _scoreText.text = _score.ToString();
    }

    public void AddScore()
    {
        _score++;
        InitializationScore();
    }
}
