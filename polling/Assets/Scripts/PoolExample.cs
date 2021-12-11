using UnityEngine;

public class PoolExample : MonoBehaviour
{
    [SerializeField] private int _poolCount = 3;
    [SerializeField] private bool _autoExpand = false;
    [SerializeField] private Box _boxPrefab;

    private PoolMono<Box> pool;

    private void Start()
    {
        this.pool = new PoolMono<Box>(this._boxPrefab, this._poolCount, this.transform);
        this.pool.autoExpand = this._autoExpand;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CreateBox();
        }
    }

    private void CreateBox()
    {
        Vector2 RandomPosition = new Vector2(Random.Range(-5f, 5f), Random.Range(-5f, 5f));
        Box box = this.pool.GetFreeElement();
        box.transform.position = RandomPosition;
    }
}
