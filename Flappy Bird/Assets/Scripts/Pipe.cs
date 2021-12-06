using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe : MonoBehaviour
{
    [SerializeField] private Transform _topPipe;
    [SerializeField] private Transform _bottomPipe;
    [SerializeField] private float _height = 200f;
    [SerializeField] private Vector2 _dirMove;

    private void Start()
    {
        _topPipe.position = new Vector2(_topPipe.position.x, _topPipe.position.y + _height / 10);
        _bottomPipe.position = new Vector2(_bottomPipe.position.x, _bottomPipe.position.y - _height / 10);
    }

    private void Update()
    {
        MovePipe();
    }

    private void MovePipe()
    {
        transform.Translate(_dirMove * GameCore.singleton._speedGame * Time.deltaTime);
    }

}
