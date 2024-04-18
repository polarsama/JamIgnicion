using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class MenuGameOver : MonoBehaviour
{
    [SerializeField] private GameObject menuGameOver;

    private Jugador jugador;

    private void Start()
    {
        jugador = GameObject.FindGameObjectsWithTag("Jugador").GetComponent<Jugador>();
        jugador.MuerteJugador += ActivarMenu;
    }

    private void ActivarMenu()
    {
        menuGameOver.SetActive(true);
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void MenuInicial(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }

    public void Salir()
    {
        Application.Quit();
    }

}
