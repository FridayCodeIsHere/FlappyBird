using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class Score : MonoBehaviour
{
    [SerializeField] private Text _userScore;
    [SerializeField] private Text _bestScore;
    [SerializeField] private Image _imageMedal;
    [SerializeField] private Sprite[] _medals;
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

    private Sprite GetMedal()
    {
        if (_score <= 5)
        {
            return _medals[0];
        }
        else if (_score > 5 && _score <= 10)
        {
            return _medals[1];
        }
        else if (_score > 10)
        {
            return _medals[2];
        }
        else
        {
            throw new System.Exception("Oops...something was wrong :(");
        }
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

    public void ShowProgress()
    {
        _userScore.text = _score.ToString();
        _bestScore.text = GetMaxScore(_scores).ToString();
        _imageMedal.sprite = GetMedal();
    }
}
