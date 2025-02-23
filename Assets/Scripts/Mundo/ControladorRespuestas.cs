using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorRespuestas : MonoBehaviour
{
    public string Die;
    public GameObject controladorContinuar;

    //Pregunta 1
    public GameObject pregunta;

    public GameObject resPlayer1;
    public GameObject resPlayer2;
    public GameObject resPlayer3;

    public GameObject resSecre1;
    public GameObject resSecre2;
    public GameObject resSecre3;


    private void Start()
    {
        pregunta.SetActive(false);

        /*resPlayer1.SetActive(false);
        resPlayer2.SetActive(false);
        resPlayer3.SetActive(false);*/

        resSecre1.SetActive(false);
        resSecre2.SetActive(false);
        resSecre3.SetActive(false);
}



    public void contuar()
    {

        controladorContinuar.SetActive(false);
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;

    }

    public void playerResp1()
    {
        pregunta.SetActive(false);
        resSecre1.SetActive(true);
    }
    public void playerResp2()
    {
        pregunta.SetActive(false);
        resSecre2.SetActive(true);
    }

    public void playerResp3()
    {
        pregunta.SetActive(false);
        resSecre3.SetActive(true);
    }

    public void PlayerRespNegro()
    {
        SceneManager.LoadScene(Die);
    }





}
