using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 10;
    private Rigidbody2D rb;
    private Vector2 movement;
    public Vector2 origBallPos;
    public Vector2 origBatPos;

    public Transform bat;

    public UnityEngine.UI.Text text;
    // Start is called before the first frame update
    void Start()
    {
        
        origBatPos = bat.position;
        origBallPos = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y);
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(50, 50));
        text = GameObject.FindGameObjectWithTag("speed Text").GetComponent<UnityEngine.UI.Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        text.text = rb.velocity.magnitude.ToString(); 
        rb.velocity = rb.velocity.normalized * speed;
    }

    void OnTriggerEnter2D()
    {
        bat.position = origBatPos;
        transform.position = origBallPos;
        rb.velocity = new Vector2(0,0);
    }
}
