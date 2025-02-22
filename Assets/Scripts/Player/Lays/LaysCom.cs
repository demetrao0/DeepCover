using UnityEngine;

public class LaysCom : MonoBehaviour
{

    public Transform posicionTomar; // La "mano" del jugador
    private Transform padreOriginal;
    private Vector3 posicionOriginal;
    private Rigidbody rb;
    private bool estaTomado = false;

    void Start()
    {
        padreOriginal = transform.parent;
        posicionOriginal = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    public void TomarObjeto(Transform mano)
    {
        if (!estaTomado)
        {
            estaTomado = true;
            transform.SetParent(mano);
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;

            if (rb != null)
            {
                rb.isKinematic = true; // Evita que el objeto tenga f�sica cuando est� en la mano
            }
        }
    }

    public void SoltarObjeto(Transform dropZone)
    {
        if (estaTomado)
        {
            estaTomado = false;
            transform.SetParent(null); // Separa el objeto de la mano

            if (rb != null)
            {
                rb.isKinematic = false; // Reactiva la f�sica al soltar
            }

            if (dropZone != null)
            {
                transform.position = dropZone.position; // Coloca el objeto en la DropZone
            }
            else
            {
                transform.position = posicionOriginal; // Si no hay DropZone, vuelve a su posici�n original
                transform.SetParent(padreOriginal); // Recupera su padre original
            }
        }
    }
}
