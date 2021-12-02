using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackground : MonoBehaviour
{
    [SerializeField] private float _speed = 2;
    private Transform _backTransform;
    private float _backSize;
    private float _backPos;

    private void Start()
    {
        _backTransform = GetComponent<Transform>();
        _backSize = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        _backPos -= _speed * Time.deltaTime;
        _backPos = Mathf.Repeat(_backPos, _backSize);
        _backTransform.position = new Vector3(_backPos, 0, 0);
    }
}
