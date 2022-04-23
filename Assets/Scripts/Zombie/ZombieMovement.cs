using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = Player.GetComponent<Transform>().position;
        transform.position = Vector2.MoveTowards(transform.position, pos, 0.005f);
    }
}
