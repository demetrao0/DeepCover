using UnityEngine;
using UnityEngine.SceneManagement;

public class IdButtons : MonoBehaviour
{
    //Cabeza
    public GameObject pato;
    public GameObject platano;
    public GameObject queso;
    //Cuerpo
    public GameObject playa;
    public GameObject traje;
    public GameObject santa;
    //pies
    public GameObject chanclas;
    public GameObject botas;
    public GameObject zapatos;

    //pintura

    public GameObject monoCafe;
    public GameObject monoNaranja;

    public string continuar;
    public string gameOver;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pato.SetActive(false);
        platano.SetActive(false);
        queso.SetActive(false);
        playa.SetActive(false);
        traje.SetActive(false);
        santa.SetActive(false);
        chanclas.SetActive(false);
        botas.SetActive(false);
        zapatos.SetActive(false);
        monoNaranja.SetActive(false);



    }
    //CABEZA
    public void ActPato()
    {
        pato.SetActive(true);
        platano.SetActive(false);
        queso.SetActive(false);
    }

    public void ActQueso()
    {
        pato.SetActive(false);
        platano.SetActive(false);
        queso.SetActive(true);
    }

    public void ActPlatano()
    {
        pato.SetActive(false);
        platano.SetActive(true);
        queso.SetActive(false);
    }
    //CUERPO
    public void ActSanta()
    {
        traje.SetActive(false);
        santa.SetActive(true);
        playa.SetActive(false);
    }


    public void ActPlaya()
    {
        traje.SetActive(false);
        playa.SetActive(true);
        santa.SetActive(false);
    }

    public void ActTraje()
    {
        santa.SetActive(false);
        traje.SetActive(true);
        playa.SetActive(false);
    }
    //PIES

    public void ActChancla()
    {
        zapatos.SetActive(false);
        chanclas.SetActive(true);
        botas.SetActive(false);
    }

    public void ActZapatos()
    {
        botas.SetActive(false);
        zapatos.SetActive(true);
        chanclas.SetActive(false);
    }


    public void ActBota()
    {
        zapatos.SetActive(false);
        botas.SetActive(true);
        chanclas.SetActive(false);
    }

    public void ActMonoWero()
    {
        monoCafe.SetActive(false);
        monoNaranja.SetActive(true);
    }


    public void Continuar()
    {
        if (monoNaranja.activeSelf)
        {
            SceneManager.LoadScene(continuar);
        }
        else
        {
            SceneManager.LoadScene(gameOver);
        }


    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
