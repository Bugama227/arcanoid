using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BatMovement : MonoBehaviour
{
    public float speed = 10.0f;
    public Rigidbody2D rb; 
    public Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), 0);
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        moveCharacter(movement);
    }

    void moveCharacter(Vector2 direction)
    {
        rb.velocity = direction * speed;
    }
}
