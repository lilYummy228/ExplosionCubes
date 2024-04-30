using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Cube))]
public class Spawner : MonoBehaviour
{
    private Cube _cube;
    private int _minCubesCount = 2;
    private int _maxCubesCount = 6;

    private void Start()
    {
        _cube = GetComponent<Cube>();
    }

    public List<Rigidbody> CreateCubes()
    {
        List<Rigidbody> cubes = new List<Rigidbody>();
        int randomCount = Random.Range(_minCubesCount, _maxCubesCount);

        for (int i = 0; i < randomCount; i++)
            cubes.Add(Instantiate(_cube).GetComponent<Rigidbody>());

        return cubes;
    }
}
