using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Player_stats : MonoBehaviour
{
    public int vida;
    public GameObject textVida;

    int contador = 0;
    // Start is called before the first frame update
    void Start()
    {
        vida = 50;
    }

    // Update is called once per frame
    void Update()
    {
        textVida.GetComponent<TextMeshProUGUI>().text = "Vida: " + vida*2;
        contador++;
        if (contador > 500)
        {
            contador = 0;
            vida += 1;
            if (vida > 50)
            {
                vida = 50;
            }
        }
        if (vida <= 0)
        {
            SceneManager.LoadScene("Scene_GameOver");
        }
    }
}
