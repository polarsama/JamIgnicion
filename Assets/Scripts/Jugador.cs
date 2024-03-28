using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jugador : MonoBehaviour
{
    public Transform mitransf;
    public float speed;
    public GameObject balaObj;
    public Transform mira;
    public float vida;
    public GameObject explosion;
    public Text textoVida;


    // Start is called before the first frame update
    void Start()
    {
        textoVida.text = vida.ToString();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Enemigo")
        {
            //Debug.Log("Te toco un enemigo");

            vida -= 100;

            Destroy(collision.gameObject);

            Instantiate(explosion, collision.transform.position, collision.transform.rotation);

        }

        if (collision.gameObject)
        {
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

        if (Input.GetKey(KeyCode.W))
        {
            mitransf.position += new Vector3(0, 1f, 0) * Time.deltaTime * speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            mitransf.position -= new Vector3(0, 1f, 0) * Time.deltaTime * speed;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(balaObj, mira.position, mira.localRotation);
        }

        textoVida.text = vida.ToString();


    }
}
