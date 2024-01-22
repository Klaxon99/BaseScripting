using UnityEngine;

public class ScaleChanger : MonoBehaviour
{
    [SerializeField] private float _scaleChangeSpeed;

    private void Update()
    {
        transform.localScale += Vector3.one * _scaleChangeSpeed * Time.deltaTime;
    }
}
