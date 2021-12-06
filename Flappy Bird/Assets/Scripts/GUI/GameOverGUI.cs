using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverGUI : MonoBehaviour
{
    public void ShowTable()
    {
        gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void HideTable()
    {
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
