using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    private Vector3 _diraction = Vector3.zero;

    private void Update()
    {
        transform.Translate(_diraction * _speed * Time.deltaTime);
    }

    public void SetDiraction(Vector3 diraction)
    {
        _diraction = diraction;
    }
}