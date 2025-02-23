using UnityEngine;

public class VirusCol : MonoBehaviour
{

    public GameObject Player;

    public GameObject controladorNoticias;

    public GameObject imagen;
    private Noticias referenciaNoticias;


    private void Start()
    {

        imagen.SetActive(false);

        if (controladorNoticias != null) // Verifica que ControladorNoticia está asignado
        {
            referenciaNoticias = controladorNoticias.GetComponent<Noticias>();

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

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Virus"))
        {

            imagen.SetActive(true);
            Player.GetComponent<Victory>().Virus();

            if (referenciaNoticias != null) // Verifica que referenciaNoticias no sea nulo antes de usarlo
            {
                referenciaNoticias.numero = 200f;
            }
            else
            {
                Debug.LogError("referenciaNoticias es nulo. No se puede asignar el valor.");
            }

        }


    }
}
