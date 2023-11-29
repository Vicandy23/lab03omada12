using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    Rigidbody2D rb;
    public float acc = 10;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity += new Vector2(Input.GetAxis("Horizontal") * acc * Time.fixedDeltaTime, Input.GetAxis("Vertical") * acc * Time.fixedDeltaTime);
    }
}
