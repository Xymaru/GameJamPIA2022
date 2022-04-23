using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGuns : MonoBehaviour
{
    int arma;

    int balasPistola=0;
    int balasPistolaInventario=0;

    int balasEscoputa=0;
    int balasEscoputaInventario=0;

    int balasSubfusil=0;
    int balasSubfusilInventario=0;
    //BATE, KATANA, PISTOLA, ESCOPUTA, SUBFUSIL  

    public GameObject Bullet;
    // Start is called before the first frame update
    void Start()
    {
        arma = 2;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (arma == 0)
        {
            
        }
        else if (arma == 1)
        {

        }
        else if (arma == 2)
        {
            if (Input.GetMouseButtonDown(0))
            {
                //Debug.Log("pium");
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Instantiate(Bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.LookRotation(Vector3.forward, mousePos - transform.position));
                Physics2D.IgnoreCollision(Bullet.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            }
            
            //transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
        }
        else if (arma == 3)
        {

        }
        else if (arma == 4)
        {

        }
    }
}
