using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jugador : MonoBehaviour
{

    [SerializeField] private Transform mitransf;
    [SerializeField] private float speed;
    [SerializeField] private GameObject balaObj;
    [SerializeField] private Transform mira;
    [SerializeField] private float vida;
    [SerializeField] private GameObject explosion;
    [SerializeField] private Text textoVida;

    private Rigidbody2D rb;
    private Vector2 moveInput;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
        textoVida.text = vida.ToString();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Enemigo")
        {
            vida = 0;

            Destroy(collision.gameObject);

            Instantiate(explosion, collision.transform.position, collision.transform.rotation);

        }

    }
    private void OnCollisionStay2D(Collision2D collision)
    {

    }
    private void OnCollisionExit2D(Collision2D collision)
    {

    }





    // Update is called once per frame
    void Update()
    {


        textoVida.text = vida.ToString();

        float moveY = Input.GetAxisRaw("Vertical");

        moveInput = new Vector2(0,moveY);

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(balaObj, mira.position, mira.localRotation);
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveInput * speed * Time.deltaTime);
    }
}
