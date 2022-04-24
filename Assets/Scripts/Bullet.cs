using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotation;
    public Vector2 direction;
    float velocity;
    void Start()
    {
        float a=0, b =0;
        rotation = transform.localEulerAngles.z;
        Debug.Log(rotation);
     
        
        velocity = 0.15f;
        GameObject player = GameObject.Find("Player");
        Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        direction.x = Mathf.Sin(rotation/180*3.1459f);
        direction.y = Mathf.Cos(rotation / 180 * 3.1459f);


        transform.position = new Vector2(transform.position.x - direction.x * velocity, transform.position.y + direction.y * velocity);
        

    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.layer == 7)
        {
            col.gameObject.GetComponent<ZombieMovement>().vida -= 10;
        }
        if(col.gameObject.tag == "bala")
        {

        }
        else
        {
            Destroy(this.gameObject);

        }
        
    }

}
