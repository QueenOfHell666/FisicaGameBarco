using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour
{
    public float rangoAlerta;

    public LayerMask capadeljugador;
    public GameObject jugador;

    bool estarAlerta;
    public float speed;

    public int contador = 10;

    private void Start()
    {
        jugador = GameObject.FindWithTag("Player");
    }

    private void Update()
    {
        estarAlerta = Physics.CheckSphere(transform.position, rangoAlerta, capadeljugador);

        if (estarAlerta == true)
        {

            transform.LookAt(new Vector3(jugador.transform.position.x, transform.position.y, jugador.transform.position.z));

        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bala"))
        {

            contador -= 2;
            Debug.Log(contador);

            if (contador <= 0)
            {
                Destroy(gameObject);
               // Debug.Log("hola");

            }


        }
    }

}

