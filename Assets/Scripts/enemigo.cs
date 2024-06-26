using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigos : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private Transform miTransf;
    [SerializeField] private GameObject explosion;
    [SerializeField] private int cantidadPuntos;
    [SerializeField] private AudioSource clip;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        miTransf.Translate(new Vector3(-1, 0, 0) * Time.deltaTime * speed);

    }
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Bala")
        {
            ControladorPuntos.Instance.SumarPuntos(cantidadPuntos);           
            Destroy(collision.gameObject);

        }

        if (collision.gameObject.tag == "Jugador")
        {
            Destroy(collision.gameObject);
            Instantiate(explosion, collision.transform.position, collision.transform.rotation);

        }
    }
}
