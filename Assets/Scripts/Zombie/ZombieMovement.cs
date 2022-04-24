using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    public GameObject Player;
    float velocitat;
    public int vida;
    public int contador = 0;
    bool tocat = false;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        velocitat = Random.Range(0.01f, 0.002f);
        vida = Random.Range(1, 5);
        vida = vida * 10;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = Player.GetComponent<Transform>().position;
        transform.position = Vector2.MoveTowards(transform.position, pos, velocitat);

        if (vida <= 0)
        {
            Destroy(this.gameObject);
        }

        if(tocat == true)
        {
            contador++;
        }
        
    }
    
    private void OnCollisionStay2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            if (contador > 200)
            {
                tocat = false;
            }
            if (tocat == false)
            {
                tocat = true;
                contador = 0;
                col.gameObject.GetComponent<Player_stats>().vida -= 5;
            }
            
            
        }
    }
}
