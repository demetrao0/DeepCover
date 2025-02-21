using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractivePhone : MonoBehaviour
{

    public float tiempoTotal = 900f; // 15 minutos (900 segundos)
    public float[] tiemposAviso = { 750f, 600f, 450f, 300f, 150f }; // Momentos donde suena la alarma
    public AudioSource audioSource; // Referencia al AudioSource
    public AudioClip[] sonidosAviso; // Sonidos específicos para cada aviso
    public string escenaDestino = "EscenaFinal"; // Nombre de la escena a la que cambiar

    private float tiempoRestante;
    private int indiceAviso = 0;
    private bool tiempoTerminado = false;



    //--------------------------------- PREGUNTAS


    public GameObject pregunta1;
    public GameObject pregunta2;
    public GameObject pregunta3;
    public GameObject pregunta4;






    void Start()
    {
        tiempoRestante = tiempoTotal;

        pregunta1.SetActive(false);
        pregunta2.SetActive(false);
        pregunta3.SetActive(false);
        pregunta4.SetActive(false);
    }

    void Update()
    {
        if (tiempoRestante > 0)
        {
            tiempoRestante -= Time.deltaTime;

            // Comprobamos si hemos llegado al siguiente aviso
            if (indiceAviso < tiemposAviso.Length && tiempoRestante <= tiemposAviso[indiceAviso])
            {
                ActivarAviso(indiceAviso);
                indiceAviso++; // Pasamos al siguiente aviso
            }
        }
        else if (!tiempoTerminado) // Cuando el tiempo llega a 0
        {
            tiempoTerminado = true;
            CambiarEscena();
        }
    }

    void ActivarAviso(int indice)
    {
        Debug.Log("Alarma " + (indice + 1) + " activada en " + tiempoRestante + " segundos");

        // Reproducir sonido específico para cada aviso
        if (indice < sonidosAviso.Length && sonidosAviso[indice] != null)
        {
            audioSource.clip = sonidosAviso[indice];
            audioSource.Play();
        }

        // Aquí puedes agregar el comportamiento único de cada aviso
        switch (indice)
        {
            case 0:
                pregunta1.SetActive(true);
                break;
            case 1:
                pregunta2.SetActive(true);
                break;
            case 2:
                pregunta3.SetActive(true);
                break;
            case 3:
                pregunta4.SetActive(true);
                break;
           
        }
    }

    void CambiarEscena()
    {
        Debug.Log("Tiempo finalizado. Cambiando a la escena: " + escenaDestino);
        SceneManager.LoadScene(escenaDestino);
    }
}
