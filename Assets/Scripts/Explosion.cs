using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Explosion : MonoBehaviour
{
    [SerializeField] private float _explosionRadius = 100;
    [SerializeField] private float _explosionForce = 500;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = gameObject.GetComponent<Rigidbody>();        
    }

    public void Explode()
    {
        _rigidbody.AddExplosionForce(_explosionForce, transform.position, _explosionRadius);
    }
}
