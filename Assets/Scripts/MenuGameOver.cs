using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.ComponentModel;

public class MenuGameOver : MonoBehaviour
{
    [SerializeField] private GameObject menuGameOver;

    private Jugador jugadorS;

    private void Start()
    {
        jugadorS = GameObject.FindGameObjectWithTag("Jugador").GetComponent<Jugador>();
        jugadorS.MuerteJugador += ActivarMenu;
    }

    private void ActivarMenu(object sender, EventArgs e)
    {
        menuGameOver.SetActive(true);
        Time.timeScale = 0.5f;
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void MenuInicial()
    {
        SceneManager.LoadScene("title");
    }

    public void Salir()
    {
        Application.Quit();
    }

}
