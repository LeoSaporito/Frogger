using System;
using UnityEngine;

public class Despawn : MonoBehaviour
{
    [SerializeField] private Vector3 viewportPosition;
    [SerializeField] private Spawner _spawner;
    [SerializeField] private float _minMargin;
    [SerializeField] private float _maxMargin;

    private void Update()
    {
        viewportPosition = Camera.main.WorldToViewportPoint(transform.position);

        bool isOutOfViewport = viewportPosition.x < _minMargin|| viewportPosition.x > _maxMargin;

        if (isOutOfViewport)
        {
            _spawner.DespawnObj(gameObject);
        }
    }
    public void InitializeScript(Spawner _spawnerScript)
    {
        _spawner = _spawnerScript;
    }
}
