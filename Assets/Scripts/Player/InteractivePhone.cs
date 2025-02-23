using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

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

    // Referencias a los objetos de pregunta
    public GameObject pregunta1;
    public GameObject pregunta2;
    public GameObject pregunta3;
    public GameObject pregunta4;

    // Referencia al texto en el Canvas para la cuenta regresiva
    public TextMeshProUGUI textoCuentaRegresiva; // Si usas TextMeshPro
    //public Text textoCuentaRegresiva; // Si usas el Text Legacy

    void Start()
    {
        tiempoRestante = tiempoTotal;





        // Inicializar las preguntas y desactivarlas
        pregunta1.SetActive(false);
        pregunta2.SetActive(false);
        pregunta3.SetActive(false);
        pregunta4.SetActive(false);

        // Asegurarse de que el texto de la cuenta regresiva esté vacío al principio
        if (textoCuentaRegresiva != null)
        {
            textoCuentaRegresiva.text = FormatTiempo(tiempoRestante);
        }
    }

    void Update()
    {
        if (tiempoRestante > 0)
        {
            tiempoRestante -= Time.deltaTime;

            // Actualizar el texto de la cuenta regresiva
            if (textoCuentaRegresiva != null)
            {
                textoCuentaRegresiva.text = FormatTiempo(tiempoRestante);
            }

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
                Time.timeScale = 0f;
                pregunta1.SetActive(true);
                Cursor.lockState = CursorLockMode.None;
                break;
            case 1:
                
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

    // Formatear el tiempo en minutos y segundos
    string FormatTiempo(float tiempo)
    {
        int minutos = Mathf.FloorToInt(tiempo / 60);
        int segundos = Mathf.FloorToInt(tiempo % 60);
        return string.Format("{0:00}:{1:00}", minutos, segundos);
    }
}
