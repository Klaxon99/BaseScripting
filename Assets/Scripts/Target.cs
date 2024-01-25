using System.Collections;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private float _diractionSpeed = 5;
    [SerializeField] private Vector3[] _route;

    private void Start()
    {
        StartCoroutine(Move());
    }

    private IEnumerator Move()
    {
        int currentDirecitonIndex = 0;

        while (true)
        {
            if (currentDirecitonIndex >= _route.Length)
            {
                currentDirecitonIndex = 0;
            }

            yield return TranslatePositions(_route[currentDirecitonIndex]);
            currentDirecitonIndex++;
        }
    }

    private IEnumerator TranslatePositions(Vector3 target)
    {
        while (transform.position != target)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, _diractionSpeed * Time.deltaTime);

            yield return null;
        }
    }
}