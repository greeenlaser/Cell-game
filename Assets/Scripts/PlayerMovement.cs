using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    //private variables
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (GetComponent<PlayerCombat>().currentHealth > 0)
        {
            float mH = Input.GetAxis("Horizontal");
            float mV = Input.GetAxis("Vertical");
            rb.velocity = new Vector3(mH * speed, rb.velocity.y, mV * speed);
        }
    }
}