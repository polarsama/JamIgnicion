using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Puntaje : MonoBehaviour
{

    public TextMeshProUGUI Score;

    // Start is called before the first frame update
    void Start()
    {
        Score = GetComponent<TextMeshProUGUI>();
        ControladorPuntos.Instance.sumarPuntosEvnt += CambiarTexto;
    }

    public void CambiarTexto(object sender, ControladorPuntos.SumarPuntosEventArgs e)
    {
        Score.text = e.PuntajeActualEvnt.ToString();
         
    }
   
}
