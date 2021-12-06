using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bird : MonoBehaviour
{
    [SerializeField] private float _jumpForce;
    private Rigidbody2D _rigidbody2D;


    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        GravityOff();
    }

    private void Update()
    {
        if (!_rigidbody2D.isKinematic && Input.GetMouseButtonDown(0))
        {
            Jump();
        }
    }

    private void Jump()
    {
        _rigidbody2D.velocity = Vector2.up * _jumpForce;
    }

    public void GravityOn()
    {
        _rigidbody2D.isKinematic = false;
    }

    public void GravityOff()
    {
        _rigidbody2D.isKinematic = true;
    }
}
