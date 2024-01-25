using System.Collections;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    private Transform _target;

    private void Start()
    {
        StartCoroutine(TranslatePositions());
    }

    public void SetTarget(Transform target)
    {
        _target = target;
    }

    private IEnumerator TranslatePositions()
    {
        while (CalculateDistanceToTarget() != Vector3.zero)
        {
            transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);

            yield return null;
        }
    }

    private Vector3 CalculateDistanceToTarget()
    {
        return transform.position - _target.position;
    }
}