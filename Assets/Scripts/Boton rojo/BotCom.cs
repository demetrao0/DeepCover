using UnityEngine;

public class BotCom : MonoBehaviour
{
    public GameObject imagen;
    public GameObject ControladorNoticia;

    private Noticias referenciaNoticias; // Variable de clase para acceder a Noticias

    private void Start()
    {
        imagen.SetActive(false);

        if (ControladorNoticia != null) // Verificamos que ControladorNoticia está asignado
        {
            referenciaNoticias = ControladorNoticia.GetComponent<Noticias>();

            if (referenciaNoticias == null)
            {
                Debug.LogError("No se encontró el script Noticias en ControladorNoticia.");
            }
        }
        else
        {
            Debug.LogError("ControladorNoticia no está asignado en el Inspector.");
        }
    }

    public void ActivarObjeto()
    {
        imagen.SetActive(true);
        Time.timeScale = 0f;

        if (referenciaNoticias != null) // Verificamos que referenciaNoticias no sea nulo antes de usarlo
        {
            referenciaNoticias.numero = 300f;
        }
        else
        {
            Debug.LogError("referenciaNoticias es nulo. No se puede asignar el valor.");
        }
    }
}
