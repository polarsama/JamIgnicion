using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PuntajeMaximo : MonoBehaviour
{

    public TextMeshProUGUI MaxScore;


    // Start is called before the first frame update
    void Start()
    {
        MaxScore = GetComponent<TextMeshProUGUI>();
        ControladorPuntos.Instance.sumarPuntosEvnt += CambiarTexto;
    }

    public void CambiarTexto(object sender, ControladorPuntos.SumarPuntosEventArgs e)
    {
        MaxScore.text = e.PuntajeMaximoEvnt.ToString();

    }

}