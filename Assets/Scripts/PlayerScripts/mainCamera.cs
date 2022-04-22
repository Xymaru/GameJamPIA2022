using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainCamera : MonoBehaviour
{
    Camera main_Camera;
    // Start is called before the first frame update
    void Start()
    {
        main_Camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        main_Camera.transform.position = this.transform.position;
        main_Camera.transform.position = new Vector3(this.transform.position.x, this.transform.position.y, -10);
    }
}
