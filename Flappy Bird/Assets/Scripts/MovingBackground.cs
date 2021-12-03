using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackground : MonoBehaviour
{
    //[SerializeField] private float _speed = 2;
    //private Transform _backTransform;
    //private float _backgroundSize;
    //private float _backgroundPosition;

    //private void Start()
    //{
    //    _backTransform = GetComponent<Transform>();
    //    _backgroundSize = GetComponent<SpriteRenderer>().bounds.size.x;
    //    Debug.Log(_backgroundSize);
    //}

    //private void Update()
    //{
    //    Move();
    //}

    //private void Move()
    //{
    //    _backgroundPosition -= _speed * Time.deltaTime;
    //    _backgroundPosition = Mathf.Repeat(_backgroundPosition, _backgroundSize);
    //    _backTransform.position = new Vector3(_backgroundPosition, 0, 0);
    //    Debug.Log(_backgroundPosition);
    //}

    [SerializeField] private float _speed = 2;
    private Transform _backgroundTransform;
    private float _backgroundSize;
    private float _backgroundPosition;

    private void Start()
    {
        _backgroundTransform = GetComponent<Transform>();
        _backgroundSize = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        _backgroundPosition -= _speed * Time.deltaTime;
        _backgroundPosition = Mathf.Repeat(_backgroundPosition, _backgroundSize);
        _backgroundTransform.position = new Vector3(_backgroundPosition, 0, 0);
    }
}
