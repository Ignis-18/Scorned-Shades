using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad = 5;
    private Rigidbody2D rb2d;
    public float maxVel = 5;


    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var velocity = rb2d.velocity;

        if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddForce(Vector2.right * velocidad);
            if (velocity.x > maxVel)
            {
                velocity.x = maxVel;
            }
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddForce(Vector2.left * velocidad);
            if (velocity.x > maxVel)
            {
                velocity.x = -maxVel;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.AddForce(Vector2.up * 275);
        }
    }
}
