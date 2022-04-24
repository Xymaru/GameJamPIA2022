using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float velocity;
    // Start is called before the first frame update
    void Start()
    {
        velocity = 0.08f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)) && (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)))
        {
            velocity = velocity*0.707f;
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + velocity);
            
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - velocity);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector2(transform.position.x - velocity, transform.position.y);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector2(transform.position.x + velocity, transform.position.y);

        }
        velocity = 0.08f;
    }
}
