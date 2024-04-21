using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Puntaje : MonoBehaviour
{



    public TextMeshProUGUI textMesh;

    // Start is called before the first frame update
    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
        ControladorPuntos.Instance.sumarPuntosEvnt += CambiarTexto;
    }

    public void CambiarTexto(object sender, ControladorPuntos.SumarPuntosEventArgs e)
    {
        textMesh.text = e.PuntajeActualEvnt.ToString();
    }

   
    void Update()
    {
   
        
    }

   
}
