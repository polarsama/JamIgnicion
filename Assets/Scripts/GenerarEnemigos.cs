using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarEnemigos : MonoBehaviour
{

    public GameObject enemigos;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Generar", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Generar()
    {
        Instantiate(enemigos, transform.position, transform.rotation);
    }
}
