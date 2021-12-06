using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    public void ShowUI()
    {
        gameObject.SetActive(true);
    }

    public void HideUI()
    {
        gameObject.SetActive(false);
    }
}
