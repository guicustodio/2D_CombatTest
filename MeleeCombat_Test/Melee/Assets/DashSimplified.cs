using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashSimplified : MonoBehaviour
{
    public Rigidbody2D rb;

    public float dashSpeed;
    private float dashTime;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    { 
            if (Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.LeftShift))
            {
                rb.velocity = Vector2.left * dashSpeed;
            }
            else if (Input.GetKeyDown(KeyCode.D) && Input.GetKeyDown(KeyCode.LeftShift))
            {
                rb.velocity = Vector2.right * dashSpeed;
            }
    }
}
