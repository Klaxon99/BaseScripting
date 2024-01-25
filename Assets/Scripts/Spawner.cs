using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] Enemy _enemyPrefab;
    [SerializeField] GameObject _enemyTarget;

    private int _spawnDelay = 2;

    private void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    private IEnumerator SpawnEnemies()
    {
        while (true)
        {
            Enemy enemy = Instantiate(_enemyPrefab, transform.position, Quaternion.identity);

            enemy.SetTarget(_enemyTarget.transform);

            yield return new WaitForSeconds(_spawnDelay);
        }
    }
}