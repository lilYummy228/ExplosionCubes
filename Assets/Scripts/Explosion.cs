using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Explosion : MonoBehaviour
{
    [SerializeField] private float _explosionRadius = 100;
    [SerializeField] private float _explosionForce = 50;

    public void Explode()
    {
        foreach (Rigidbody explodableObjects in GetExplodableObjects())
            explodableObjects.AddExplosionForce(_explosionForce, transform.position, _explosionRadius);
    }

    public void MultiplyValues(int multiplier)
    {
        _explosionRadius *= multiplier;
        _explosionForce *= multiplier;
    }

    private List<Rigidbody> GetExplodableObjects()
    {
        Collider[] hits = Physics.OverlapSphere(transform.position, _explosionRadius);

        List<Rigidbody> cubes = new();

        foreach (Collider hit in hits)
            if (hit.attachedRigidbody != null)
                cubes.Add(hit.attachedRigidbody);

        return cubes;
    }
}
