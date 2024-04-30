using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private float _explosionRadius = 20;
    [SerializeField] private float _explosionForce = 500;
    [SerializeField] private Spawner _spawner;

    public void Explode()
    {
        foreach (Rigidbody cube in _spawner.CreateCubes())
            cube.AddExplosionForce(_explosionForce, transform.position, _explosionRadius);
    }
}
