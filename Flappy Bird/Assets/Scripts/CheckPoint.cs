using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CheckPoint : MonoBehaviour
{
    public event UnityAction onCheckPoint;

    private void Start()
    {
        onCheckPoint += Score.singleton.AddScore;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Bird bird = collision.GetComponent<Bird>();
        if (bird)
        {
            Debug.Log("CheckPoint works");
            onCheckPoint?.Invoke();
        }
    }
}
