using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorPuntos : MonoBehaviour
{
    public static ControladorPuntos Instance;
    [SerializeField] private int PuntajeActual;
    [SerializeField] private int PuntajeMaximo;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }else
        {
            Instance = this;
        }
    }

    private void Start()
    {
        PuntajeMaximo = PlayerPrefs.GetInt("Maximo");
    }

    public void SumarPuntos(int puntos)
    {
        PuntajeActual += puntos;
        if (PuntajeActual > PuntajeMaximo)
        {
            PuntajeMaximo = PuntajeActual;
            PlayerPrefs.SetInt("Maximo", PuntajeMaximo);
        }
    }


}
