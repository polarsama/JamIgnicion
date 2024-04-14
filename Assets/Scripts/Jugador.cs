using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Jugador : MonoBehaviour
{

    [SerializeField] private Transform mitransf;
    [SerializeField] private float speed;
    [SerializeField] private GameObject balaObj;
    [SerializeField] private Transform mira;
    [SerializeField] private GameObject explosion;
    [SerializeField] private int vida;

    private TextMeshProUGUI textMesh;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Animator pjAnimator;
   


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        pjAnimator = GetComponent<Animator>();
        textMesh = GetComponent<TextMeshProUGUI>();
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Enemigo")
        {
            Destroy(collision.gameObject);

            Instantiate(explosion, collision.transform.position, collision.transform.rotation);

        }

    }
    private void OnCollisionExit2D(Collision2D collision)
    {

    }

    // Update is called once per frame
    void Update()
    {

        //textMesh.text = vida.ToString("100");

        float moveY = Input.GetAxisRaw("Vertical");

        moveInput = new Vector2(0, moveY);

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
