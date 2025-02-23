using UnityEngine;

public class PalancaInteractive : MonoBehaviour
{

    public GameObject Player;
    public GameObject anim;
    public GameObject Imagen;
    public GameObject ControladorNoticia;

    private Noticias referenciaNoticias; // Variable de clase

    void Start()
    {
        Imagen.SetActive(false);

        if (ControladorNoticia != null) // Verifica que ControladorNoticia está asignado
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
        Cursor.lockState = CursorLockMode.None;
        anim.GetComponent<Anim>().Animacion();

        Imagen.SetActive(true);

        Player.GetComponent<Victory>().AliensLibres();

        if (referenciaNoticias != null) // Verifica que referenciaNoticias no sea nulo antes de usarlo
        {
            referenciaNoticias.numero = 100f;
        }
        else
        {
            Debug.LogError("referenciaNoticias es nulo. No se puede asignar el valor.");
        }
    }
}
