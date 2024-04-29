using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class Splitter : MonoBehaviour
{
    [SerializeField, Range(0, 100)] private int _chanceToSplit = 100;
    [SerializeField] private float _explosionRadius;
    [SerializeField] private float _explosionForce;

    private int _minCubesCount = 2;
    private int _maxCubesCount = 6;
    private int _devider = 2;
    private int _randomValue;
    private Transform _gameObject;

    private void Start()
    {
        _randomValue = Random.Range(0, 100);

        gameObject.GetComponent<MeshRenderer>().material.color =
            new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f));
    }

    private void OnMouseUpAsButton()
    {
        if (_randomValue < _chanceToSplit)
        {
            _chanceToSplit /= _devider;

            ScaleDown();

            foreach (Rigidbody cube in GetObjects())
                cube.AddExplosionForce(_explosionForce, transform.position, _explosionRadius);
        }

        Destroy(gameObject);
    }

    private List<Rigidbody> GetObjects()
    {
        List<Rigidbody> cubes = new List<Rigidbody>();
        int randomCount = Random.Range(_minCubesCount, _maxCubesCount);

        for (int i = 0; i < randomCount; i++)
            cubes.Add(Instantiate(_gameObject).GetComponent<Rigidbody>());

        return cubes;
    }

    private void ScaleDown()
    {
        _gameObject = gameObject.transform;
        _gameObject.transform.localScale /= _devider;
    }
}
