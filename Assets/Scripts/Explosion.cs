using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Explosion : MonoBehaviour
{
    [SerializeField] private float _explosionRadius = 100;
    [SerializeField] private float _explosionForce = 500;

    public void Explode(List<Cube> cubes)
    {
        foreach (Cube cube in cubes)
        {
            Rigidbody rigidbody = cube.GetComponent<Rigidbody>();
            rigidbody.AddExplosionForce(_explosionForce, transform.position, _explosionRadius);
        }
    }
}
