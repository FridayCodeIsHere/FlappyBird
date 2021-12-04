using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] private Transform _topPipe;
    [SerializeField] private Transform _bottomPipe;
    [SerializeField] private float _height = 10f;

    private void Start()
    {
        _topPipe.position = new Vector2(_topPipe.position.x, _topPipe.position.y + _height / 10);
        _bottomPipe.position = new Vector2(_bottomPipe.position.x, _bottomPipe.position.y - _height / 10);
    }

}
