using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Jugador : MonoBehaviour
{

    [SerializeField] private Transform mitransf;
    [SerializeField] private float speed;
    [SerializeField] private GameObject balaObj;
    [SerializeField] private Transform mira;
    [SerializeField] private GameObject explosion;
    [SerializeField] private int vida;

    public event EventHandler MuerteJugador;

    private Rigidbody2D rb;
    private Vector2 moveInput;
   // private Animator pjAnimator;
   


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //pjAnimator = GetComponent<Animator>();
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Enemigo")
        {
            MuerteJugador?.Invoke(this,EventArgs.Empty);   

            Instantiate(explosion, collision.transform.position, collision.transform.rotation);
            Destroy(collision.gameObject);           

        }

    }

    // Update is called once per frame
    void Update()
    {

        float moveY = Input.GetAxisRaw("Vertical");

        moveInput = new Vector2(0, moveY);


        if (!MenuPausa.isPausa) { 
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(balaObj, mira.position, mira.localRotation);
            }
        }
    }


    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveInput * speed * Time.deltaTime);
    }
}
