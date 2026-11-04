using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Flipper : MonoBehaviour
{
    private Rigidbody2D rb;
    
    private float flipperAngle = 0.0f;
    [SerializeField] private float flipperTargetAngle;
    [SerializeField] private float flipperStartAngle;

    [SerializeField] private Rigidbody2D ballRb;
    [SerializeField] private string flipperAction;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        flipperAngle = flipperStartAngle;
    }

    private void Update()
    {
        flipperAngle = Mathf.LerpAngle(flipperAngle, InputSystem.actions.FindAction(flipperAction).IsPressed() ? flipperTargetAngle : flipperStartAngle, 8f * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        rb.MoveRotation(flipperAngle);
    }
}
