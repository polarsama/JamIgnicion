using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public GameObject pausaMenu;
    public static bool isPausa;


    // Start is called before the first frame update
    void Start()
    {
        pausaMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPausa)
            {
                Resumen();
            }
            else
            {
                JuegoPausa();
            }
        }
    }

    public void JuegoPausa()
    {
        pausaMenu.SetActive(true);
        Time.timeScale = 0f;
        isPausa = true;
    }

    public void Resumen()
    {
        pausaMenu.SetActive(false);
        Time.timeScale = 1f;
        isPausa = false;
    }

    public void IrMenuPrincipal()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("title");
    }

    public void SalirPausa()
    {
        Application.Quit();
    }


}
