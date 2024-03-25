using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float speed;
    public Transform miTransf;
    public GameObject explosion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        miTransf.Translate(new Vector3(0, 1, 0) * Time.deltaTime * speed); 
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Enemigo")
        {
            Debug.Log("Te toco un enemigo");

            Destroy(collision.gameObject);

            Instantiate(explosion, collision.transform.position, collision.transform.rotation);
        }

    }
}
