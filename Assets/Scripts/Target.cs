using System.Collections;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private Vector3 _targetPosition;
    [SerializeField] private float _diractionSpeed = 5;

    private void Start()
    {
        StartCoroutine(Move());
    }

    private IEnumerator Move()
    {
        while (transform.position != _targetPosition)
        {
            transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _diractionSpeed * Time.deltaTime);

            yield return null;
        }
    }
}
