using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject _enemyPrefab;
    [SerializeField] Vector3 _enemyDiraction = new Vector3(1, 1, 0);

    private float _spawnPause = 2f;
    private float _timer = 0f;

    private void Update()
    {
        if (_timer >= _spawnPause)
        {
            _timer = 0f;
            GameObject enemy = Instantiate(_enemyPrefab,transform.position, Quaternion.identity);

            enemy.GetComponent<Mover>().SetDiraction(_enemyDiraction);
        }

        _timer += Time.deltaTime;
    }
}
