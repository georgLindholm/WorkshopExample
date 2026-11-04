using System;
using UnityEngine;
using UnityEngine.Events;

public class Ball : MonoBehaviour
{
    [SerializeField] private UnityEvent onCollision;

    private void OnCollisionEnter2D(Collision2D collision)
    {   
        onCollision.Invoke();
    }
}
