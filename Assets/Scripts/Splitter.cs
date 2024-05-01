using UnityEngine;

public class Splitter : MonoBehaviour
{
    [SerializeField, Range(0, 100)] private int _chanceToSplit = 100;
    [SerializeField] private Explosion _explosion;
    [SerializeField] private Spawner _spawner;

    private Cube _cube;
    private int _randomValue;
    private int _constant = 2;
    private int _minValue = 0;
    private int _maxValue = 100;

    private void Start()
    {
        _randomValue = Random.Range(_minValue, _maxValue);
        _cube = GetComponent<Cube>();
    }

    private void OnMouseUpAsButton()
    {
        ShouldSplitUp(_randomValue < _chanceToSplit);

        Destroy(gameObject);
    }

    private void ShouldSplitUp(bool isSplit)
    {
        if (isSplit)
        {
            DivideValues();
            _explosion.MultiplyValues(_constant);

            _spawner.CreateCubes(_cube);
        }
        else
        {
            _explosion.Explode();
        }
    }

    private void DivideValues()
    {
        _chanceToSplit /= _constant;
        _cube.transform.localScale /= _constant;        
    }
}
