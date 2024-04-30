using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private int _minCubesCount = 2;
    private int _maxCubesCount = 6;

    public List<Cube> CreateCubes(Cube cube)
    {
        List<Cube> cubes = new List<Cube>();    
        int randomCount = Random.Range(_minCubesCount, _maxCubesCount);

        for (int i = 0; i < randomCount; i++)
            cubes.Add(Instantiate(cube));

        return cubes;
    }
}
