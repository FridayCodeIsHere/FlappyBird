using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour
{
    [SerializeField] private float _lifeTime = 2f;
    private void OnEnable()
    {
        this.StartCoroutine(LifeRoutine());
    }

    private void OnDisable()
    {
        this.StopCoroutine(LifeRoutine());
    }

    private IEnumerator LifeRoutine()
    {
        yield return new WaitForSecondsRealtime(this._lifeTime);
        this.Deactivate();
    }

    private void Deactivate()
    {
        this.gameObject.SetActive(false);
    }
}
