using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBackground : MonoBehaviour
{

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
        _backgroundPosition -= GameCore.singleton._speedGame / 2 * Time.deltaTime;
        _backgroundPosition = Mathf.Repeat(_backgroundPosition, _backgroundSize);
        _backgroundTransform.position = new Vector3(_backgroundPosition, 0, 0);
    }
}
