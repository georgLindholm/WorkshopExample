using System;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    private Rigidbody2D rb;

    private float spinnerAngle = 0.0f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        spinnerAngle += 90 * Time.deltaTime;

        if (spinnerAngle >= 360.0f)
        {
            spinnerAngle = 0.0f;
        }
        
        rb.MoveRotation(spinnerAngle);
    }
}
