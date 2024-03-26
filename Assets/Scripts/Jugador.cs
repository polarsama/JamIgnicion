using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public Transform mitransf;
    public float speed;
    public GameObject balaObj;
    public Transform mira;
    public float vida;
    public GameObject explosion;



    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Enemigo")
        {
            //Debug.Log("Te toco un enemigo");

            //vida -= 10;

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
        //if (Input.GetKey(KeyCode.D))
        //{
        //    mitransf.position += new Vector3(1f, 0, 0) * Time.deltaTime * speed;
        //}

        //if (Input.GetKey(KeyCode.A))
        //{
        //    mitransf.position -= new Vector3(1f, 0, 0) * Time.deltaTime * speed;
        //}

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

    }
}
