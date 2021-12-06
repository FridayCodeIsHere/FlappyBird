using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingGround : MonoBehaviour
{
    private Transform _groundTransform;
    private bool _isMove = false;
    private float _groundSize;
    private float _groundPosition;
    private float _speed = 2f;

    private void Start()
    {
        _groundTransform = GetComponent<Transform>();
        _groundSize = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void Update()
    {
        if (_isMove)
        {
            Move();
        }
    }

    private void Move()
    {
        _groundPosition -= _speed * Time.deltaTime / 2f;
        _groundPosition = Mathf.Repeat(_groundPosition, _groundSize);
        _groundTransform.position = new Vector3(_groundPosition, _groundTransform.position.y, 0);

    }

    public void MoveOn()
    {
        _isMove = true;
    }

    public void MoveOff()
    {
        _isMove = false;
    }
}
