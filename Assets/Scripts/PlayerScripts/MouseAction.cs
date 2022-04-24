using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseAction : MonoBehaviour
{
    //public GameObject player;
    void FixedUpdate()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);

      




    }
}
