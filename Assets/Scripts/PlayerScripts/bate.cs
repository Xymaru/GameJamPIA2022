using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bate : MonoBehaviour
{
    int timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        GameObject player = GameObject.Find("Player");
        Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer++;
        if (timer > 100)
        {
            Destroy(this.gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.layer == 7)
        {
            col.gameObject.GetComponent<ZombieMovement>().vida -= 7;
        }
        Destroy(this.gameObject);

    }
}
