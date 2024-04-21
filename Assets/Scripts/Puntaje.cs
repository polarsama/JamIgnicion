using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Puntaje : MonoBehaviour
{

    private float puntos;

    public TextMeshProUGUI textMesh;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        textMesh.text = PlayerPrefs.GetInt("Maximo").ToString();
    }

    // Update is called once per frame
    void Update()
    {
   
        textMesh.text = puntos.ToString("0");
    
    }

    public void SumarPuntos(float puntosEntrada)
    {
        puntos += puntosEntrada;
    }
}
