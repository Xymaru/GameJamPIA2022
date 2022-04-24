using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerGuns : MonoBehaviour
{
    int arma;

    int balesPistolaRecamara;
    int balesPistolaReserva=21;

    int balasEscoputaRecamara=7;
    int balasEscoputaReserva = 5;

    int balasSubfusilRecamara=7;
    int balasSubfusilReserva = 5;

    public GameObject textBalesRecamara;
    public GameObject textBalesReserva;
    public GameObject textArma;
    //BATE, KATANA, PISTOLA, ESCOPUTA, SUBFUSIL  

    public GameObject Bullet;
    public GameObject Bate;
    public GameObject Katana;

    public int delayArma;
    // Start is called before the first frame update
    void Start()
    {
        balesPistolaRecamara = 7;
        arma = 2;
        delayArma = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (delayArma > 0)
        {
            delayArma++;
        }

        if (delayArma > 50)
        {
            delayArma = 0;
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            arma = 0;
            delayArma = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            arma = 1;
            delayArma = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            arma = 2;
            delayArma = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            arma = 3;
            delayArma = 0;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            arma = 4;
            delayArma = 0;
        }










        if (arma == 0)
        {
            if (Input.GetMouseButtonDown(0) && delayArma == 0)
            {
                delayArma++;
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Instantiate(Bate, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.LookRotation(Vector3.forward, mousePos - transform.position));
                Physics2D.IgnoreCollision(Bate.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            }
            textBalesRecamara.GetComponent<TextMeshProUGUI>().text = "";
            textBalesReserva.GetComponent<TextMeshProUGUI>().text = "";
            textArma.GetComponent<TextMeshProUGUI>().text = "Arma: Bate";
        }
        else if (arma == 1)
        {
            if (Input.GetMouseButtonDown(0) && delayArma == 0)
            {
                delayArma++;
                Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                Instantiate(Katana, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.LookRotation(Vector3.forward, mousePos - transform.position));
                Physics2D.IgnoreCollision(Katana.GetComponent<Collider2D>(), GetComponent<Collider2D>());
            }
            textBalesRecamara.GetComponent<TextMeshProUGUI>().text = "";
            textBalesReserva.GetComponent<TextMeshProUGUI>().text = "";
            textArma.GetComponent<TextMeshProUGUI>().text = "Arma: Katana";
        }
        else if (arma == 2)
        {
            if (Input.GetMouseButtonDown(0) && delayArma == 0)
            {
                delayArma++;
                //Debug.Log("pium");
                if (balesPistolaRecamara > 0)
                {
                    Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    Instantiate(Bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.LookRotation(Vector3.forward, mousePos - transform.position));
                    Physics2D.IgnoreCollision(Bullet.GetComponent<Collider2D>(), GetComponent<Collider2D>());
                    balesPistolaRecamara--;
                }
                else
                {

                }
                
            }
            if(Input.GetKey(KeyCode.R) && balesPistolaRecamara < 7 && balesPistolaReserva > 0)
            {
                int balaAux = 7 - balesPistolaRecamara;
                while (true)
                {
                    if (balesPistolaReserva == 0)
                    {
                        break;
                    }
                    else
                    {
                        if (balesPistolaRecamara < 7)
                        {
                            balesPistolaRecamara++;
                            balesPistolaReserva--;
                        }
                    }
                    if (balesPistolaRecamara == 7)
                    {
                        break;
                    }
                }
            }
            textBalesRecamara.GetComponent<TextMeshProUGUI>().text = "Bales Recamara: " + balesPistolaRecamara;
            textBalesReserva.GetComponent<TextMeshProUGUI>().text = "Bales Reserva: " + balesPistolaReserva;
            textArma.GetComponent<TextMeshProUGUI>().text = "Arma: Pistola";
            //transform.rotation = Quaternion.LookRotation(Vector3.forward, mousePos - transform.position);
        }
        else if (arma == 3)
        {
            if (Input.GetMouseButtonDown(0) && delayArma == 0)
            {
                delayArma++;
                //Debug.Log("pium");
                if (balasEscoputaRecamara > 0)
                {
                    Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                    Instantiate(Bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.LookRotation(Vector3.forward, mousePos - transform.position));
                    mousePos.x += Random.Range(-1, 1);
                    mousePos.y += Random.Range(-1, 1);
                    Instantiate(Bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.LookRotation(Vector3.forward, mousePos - transform.position));
                    mousePos.x += Random.Range(-1, 1);
                    mousePos.y += Random.Range(-1, 1);
                    Instantiate(Bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.LookRotation(Vector3.forward, mousePos - transform.position));
                    Physics2D.IgnoreCollision(Bullet.GetComponent<Collider2D>(), GetComponent<Collider2D>());

                    balasEscoputaRecamara--;
                }
                else
                {

                }

            }
            if (Input.GetKey(KeyCode.R) && balasEscoputaRecamara < 7 && balasEscoputaReserva > 0)
            {
                int balaAux = 7 - balasEscoputaRecamara;
                while (true)
                {
                    if (balasEscoputaReserva == 0)
                    {
                        break;
                    }
                    else
                    {
                        if (balasEscoputaRecamara < 7)
                        {
                            balasEscoputaRecamara++;
                            balasEscoputaReserva--;
                        }
                    }
                    if (balasEscoputaRecamara == 7)
                    {
                        break;
                    }
                }
            }
            textBalesRecamara.GetComponent<TextMeshProUGUI>().text = "Bales Recamara: " + balasEscoputaRecamara;
            textBalesReserva.GetComponent<TextMeshProUGUI>().text = "Bales Reserva: " + balasEscoputaReserva;
            textArma.GetComponent<TextMeshProUGUI>().text = "Arma: Escop*ta";
        }
        else if (arma == 4)
        {
            if (Input.GetMouseButton(0) && delayArma == 0)
            {
                //Debug.Log("pium");
                delayArma++;
                
                    if (balasSubfusilRecamara > 0)
                    {
                        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                        Instantiate(Bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.LookRotation(Vector3.forward, mousePos - transform.position));
                        Physics2D.IgnoreCollision(Bullet.GetComponent<Collider2D>(), GetComponent<Collider2D>());
                        balasSubfusilRecamara--;
                    }
                    else
                    {

                    }
                
               
                    
                

            }
            if (Input.GetKey(KeyCode.R) && balasSubfusilRecamara < 7 && balasSubfusilReserva > 0)
            {
                int balaAux = 7 - balasSubfusilRecamara;
                while (true)
                {
                    if (balasSubfusilReserva == 0)
                    {
                        break;
                    }
                    else
                    {
                        if (balasSubfusilRecamara < 7)
                        {
                            balasSubfusilRecamara++;
                            balasSubfusilReserva--;
                        }
                    }
                    if (balasSubfusilRecamara == 7)
                    {
                        break;
                    }
                }
            }
            textBalesRecamara.GetComponent<TextMeshProUGUI>().text = "Bales Recamara: " + balasSubfusilRecamara;
            textBalesReserva.GetComponent<TextMeshProUGUI>().text = "Bales Reserva: " + balasSubfusilReserva;
            textArma.GetComponent<TextMeshProUGUI>().text = "Arma: Subfusil";
        }
    }
}
