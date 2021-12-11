using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeObject : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

        Bird bird = collision.gameObject.GetComponent<Bird>();
        if (bird)
        {
            GameCore.singleton.gameOver?.Invoke();
        }
    }
}
