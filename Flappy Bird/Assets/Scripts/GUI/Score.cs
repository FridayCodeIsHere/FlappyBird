using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class Score : MonoBehaviour
{
    [SerializeField] private Text _userScore;
    [SerializeField] private Text _bestScore;
    public static Score singleton { get; private set; }
    public List<int> _scores { get; private set; }
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
        _scores = new List<int>();
        _scoreText = GetComponent<Text>();
        InitializationScore();
    }

    private void InitializationScore()
    {
        _scoreText.text = _score.ToString();
    }

    private int GetMaxScore(List<int> scores)
    {
        if (scores.Count == 0)
        {
            return _score;
        }

        int maxScore = 0;
        foreach (int score in scores)
        {
            if (maxScore < score)
            {
                maxScore = score;
            }
        }
        return maxScore;
    }

    public void AddScore()
    {
        _score++;
        InitializationScore();
    }

    public void PutScore()
    {
        _scores.Add(_score);
    }

    public void NullifyScore()
    {
        _score = 0;
        InitializationScore();
    }

    public void ShowAllScores()
    {
        _userScore.text = _score.ToString();
        _bestScore.text = GetMaxScore(_scores).ToString();
    }
}
