using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KakHochesh : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform bat, ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.velocity.magnitude == 0)
        {
            ball.position = new Vector2(bat.position.x, ball.position.y);
            
            if(Input.GetAxis("Fire1") > 0)
            {
                rb.AddForce(new Vector2(50, 50));
            }
        }
    }
}
