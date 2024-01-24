using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector3 _diraction = Vector3.zero;

    public void SetDiraction(Vector3 diraction)
    {
        _diraction = diraction;
    }

    private void Update()
    {
        transform.Translate(_diraction * _speed * Time.deltaTime);
    }
}
