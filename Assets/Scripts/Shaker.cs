using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Shaker : MonoBehaviour
{
    private Vector3 startPosition;
    private float trauma = 0.0f;

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        if (trauma > 0.0f)
        {
            trauma -= Time.deltaTime;
        }

        transform.position = startPosition + Random.insideUnitSphere * trauma + (Vector3.back * 20);
    }

    public void AddTrauma(float _addition)
    {
        trauma += _addition;
        
        trauma = Mathf.Clamp(trauma, 0.0f, 2.0f);
    }
}
