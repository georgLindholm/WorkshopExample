using System;
using UnityEngine;

public class Flipper : MonoBehaviour
{
    private Rigidbody2D rb;
    
    private float flipperAngle = 0.0f;
    [SerializeField] private float flipperTargetAngle;
    [SerializeField] private float flipperStartAngle;

    [SerializeField] private Rigidbody2D ballRb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        flipperAngle = flipperStartAngle;
    }

    void FixedUpdate()
    {
        flipperAngle = Mathf.LerpAngle(flipperAngle, ballRb.position.y < -11f ? flipperTargetAngle : flipperStartAngle, 8f * Time.deltaTime);
        
        rb.MoveRotation(flipperAngle);
    }
}
