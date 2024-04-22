using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ControladorPuntos : MonoBehaviour
{
    public static ControladorPuntos Instance;
    [SerializeField] private int PuntajeActual;
    [SerializeField] private int PuntajeMaximo;

    public event EventHandler<SumarPuntosEventArgs> sumarPuntosEvnt;

    public class SumarPuntosEventArgs: EventArgs
    {
        public int PuntajeActualEvnt;
        public int PuntajeMaximoEvnt;
    }

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

        sumarPuntosEvnt?.Invoke(this, new SumarPuntosEventArgs { PuntajeActualEvnt = PuntajeActual, PuntajeMaximoEvnt = PuntajeMaximo });
    }


}
