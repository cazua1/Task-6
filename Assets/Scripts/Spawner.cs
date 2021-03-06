using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _unitPrefab;
    [SerializeField] private float _spawnDelay;
    [SerializeField] private Transform[] _points;

    private Transform _currentPoint;     

    private void Start()
    {
        StartCoroutine(SpawnEnemy(_spawnDelay));
    }

    private IEnumerator SpawnEnemy(float spawnDelay)
    {
        var delay = new WaitForSeconds(spawnDelay);

        while (true)
        {
            _currentPoint = _points[Random.Range(0, _points.Length)];
            Instantiate(_unitPrefab, _currentPoint.position, Quaternion.identity);
            yield return delay;
        }
    }
}
