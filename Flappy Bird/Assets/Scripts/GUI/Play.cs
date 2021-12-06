using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{

    private void OnMouseDown()
    {
        GameCore.singleton.gameStart?.Invoke();
    }
}
