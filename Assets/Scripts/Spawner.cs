using UnityEngine;

public class Spawner : MonoBehaviour
{
    private int _minCubesCount = 2;
    private int _maxCubesCount = 6;

    public void CreateCubes(Cube cube)
    {
        int randomCount = Random.Range(_minCubesCount, _maxCubesCount);

        for (int i = 0; i < randomCount; i++)
            Instantiate(cube);
    }
}
