using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Zombies : MonoBehaviour
{
    public int timer;
    // Start is called before the first frame update
    public GameObject zombie;
    public GameObject player;
    void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    
    void FixedUpdate()
    {
        timer++;
        if (timer > 250)
        {
            timer = 0;
            float x = 0;
            float y = 0;
            while (x < 12 && x > -12 && y < 7 && y > -7)
            {
                x = Random.Range(-30f, 30f);
                y = Random.Range(-30f, 30f);
                
            }
            
            Instantiate(zombie, new Vector3(player.transform.position.x + x, player.transform.position.y + y, 0), Quaternion.identity);
        }
    }
}
