using System.Collections;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private Vector3 _direction = Vector3.forward;
    [SerializeField] private float _directionSpeed;
    [SerializeField] private float _rotationSpeed;

    void Start()
    {
        StartCoroutine(Move());
    }

    private IEnumerator Move()
    {
        while (true)
        {
            transform.Translate(_direction * _directionSpeed * Time.deltaTime);
            transform.Rotate(Vector3.up, _rotationSpeed * Time.deltaTime);

            yield return null;
        }
    }
}
