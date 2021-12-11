using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeRandom : MonoBehaviour
{
    [SerializeField] private Pipe _pipePrefab;
    [SerializeField] private Transform _container;
    [SerializeField] private bool _autoExpand = false;
    [SerializeField] private int _poolCount = 3;

    private float _timer = 4f;
    private float _verticalRandomPipe = 1f;
    private float _horizontalRandomPipe = 1f;
    private Coroutine randomPipe;

    private PoolMono<Pipe> _pool;

    private void Start()
    {
        _pool = new PoolMono<Pipe>(_pipePrefab, _poolCount, _container);
        _pool.autoExpand = _autoExpand;
    }

    private IEnumerator CreatePipe()
    {
        while (true)
        {
            float randomX = Random.Range(-_horizontalRandomPipe, _horizontalRandomPipe);
            float randomY = Random.Range(-_verticalRandomPipe, _verticalRandomPipe);
            Vector2 position = new Vector2(transform.position.x + randomX, transform.position.y + randomY);
            Pipe pipe = _pool.GetFreeElement();
            pipe.transform.position = position;
            yield return new WaitForSeconds(_timer);
        }
    }

    public void StartRandom()
    {
        randomPipe = StartCoroutine(CreatePipe());

    }

    public void StopRandom()
    {
        StopCoroutine(randomPipe);
    }

    public void ComplicatedRandom()
    {
        _verticalRandomPipe += 0.7f;
        _horizontalRandomPipe -= 0.4f;
        _timer--;
    }

    public void DeactivateAllPipies()
    {
        _pool.DeactivateAllObjects();
    }

}
