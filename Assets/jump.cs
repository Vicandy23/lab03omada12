using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpSpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            rb.velocity += new Vector2(jumpSpeed, jumpSpeed);
        }
    }
}
