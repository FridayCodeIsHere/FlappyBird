using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class PoolMono<T> where T : MonoBehaviour
{
    public T prefab;
    public bool autoExpand { get; set; }
    public Transform container { get; }
    private List<T> pool;

    public PoolMono(T prefab, int count, Transform container = null)
    {
        this.prefab = prefab;
        this.container = container;
        CreatePool(count);
    }

    private void CreatePool(int count)
    {
        this.pool = new List<T>();
        for (int i = 0; i < count; i++)
        {
            CreateObject();
        }
    }

    private T CreateObject(bool isActiveByDefault = false)
    {
        T createdObject = Object.Instantiate(this.prefab, this.container);
        createdObject.gameObject.SetActive(isActiveByDefault);
        this.pool.Add(createdObject);
        return createdObject;
    }

    public bool HasFreeElement(out T element)
    {
        foreach (T mono in pool)
        {
            if (!mono.gameObject.activeInHierarchy)
            {
                element = mono;
                mono.gameObject.SetActive(true);
                return true;
            }
        }
        element = null;
        return false;
    }

    public T GetFreeElement()
    {
        if (HasFreeElement(out T element))
        {
            return element;
        }
        if (autoExpand)
        {
            return CreateObject(true);
        }
        throw new System.Exception($"There is no free element type of {typeof(T)}");
    }

    public void DeactivateAllObjects()
    {
        foreach (T mono in pool)
        {
            if (mono.gameObject.activeInHierarchy)
            {
                mono.gameObject.SetActive(false);
            }
        }
    }
}
