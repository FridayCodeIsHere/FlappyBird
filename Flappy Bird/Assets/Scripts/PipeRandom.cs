using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeRandom : MonoBehaviour
{
    [SerializeField] private GameObject _pipe;
    private bool _isGame = true;
    private float _timer = 4f;
    private float _verticalRandomPipe = 1f;
    private float _horizontalRandomPipe = 1f;

    private void Start()
    {
        StartCoroutine("CreatePipe");
    }

    private IEnumerator CreatePipe()
    {
        while (_isGame)
        {
            float randomX = Random.Range(-_horizontalRandomPipe, _horizontalRandomPipe);
            float randomY = Random.Range(-_verticalRandomPipe, _verticalRandomPipe);
            Vector2 position = new Vector2(transform.position.x + randomX, transform.position.y + randomY);
            GameObject pipe = Instantiate(_pipe, position, Quaternion.identity);
            Destroy(pipe, 14f);
            yield return new WaitForSeconds(_timer);
        }
    }

    public void ComplicatedRandom()
    {
        _verticalRandomPipe += 0.7f;
        _horizontalRandomPipe -= 0.4f;
    }
    
}
