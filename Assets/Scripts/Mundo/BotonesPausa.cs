using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesPausa : MonoBehaviour
{
    public GameObject pausa;
    public GameObject controles;

    public string quit;


    public GameObject modNum;
    private Paused refPaused;


    private void Start()
    {
        controles.SetActive(false);

        refPaused = modNum.GetComponent<Paused>();

    }

    public void pausaOff()
    {
        Cursor.lockState = CursorLockMode.Locked;
        pausa.SetActive(false);
        Time.timeScale = 1f;
        refPaused.numero = 0f;


    }


    public void controlesOn()
    {

        pausa.SetActive(false);
        controles.SetActive(true);

    }

    public void controlesOff()
    {

        pausa.SetActive(true);
        controles.SetActive(false);

    }


    public void Salir ()
    {

        SceneManager.LoadScene(quit);


    }


}
