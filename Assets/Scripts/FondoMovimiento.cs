using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FondoMovimiento : MonoBehaviour
{
    

    [SerializeField] private Vector2 velocidadMovimiento;
    public float IncrementoSpeed;
    public float LapsoNivel;
    public float IncrementoLapso;

    private Vector2 offset;
    private Material material;

    private void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;
    }

    private void Update()
    {
        offset = velocidadMovimiento * Time.deltaTime;
        material.mainTextureOffset += offset;

        if (Time.time > LapsoNivel)
        {
            velocidadMovimiento += new Vector2(IncrementoSpeed,0);
            LapsoNivel += IncrementoLapso;
        }
    }
}
