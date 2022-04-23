using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    public GameObject Player;
    float velocitat;
    public int vida;

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
    }
}
