using UnityEngine;

public class VirusCom : MonoBehaviour
{
    public Transform posicionTomar;
    private Transform padreOriginal;
    private Vector3 posicionOriginal;
    private Rigidbody rb;
    private bool estaTomado = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        padreOriginal = transform.parent;
        posicionOriginal = transform.position;
        rb = GetComponent<Rigidbody>();
    }


    public void TomarObjeto (Transform mano)
    {
        if (!estaTomado)
        {
            estaTomado = true;
            transform.SetParent(mano);
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;

            if (rb != null)
            {
                rb.isKinematic = true;
            }


        }
    }


    public void soltarObjeto (Transform dropZone)
    {
        if (estaTomado)
        {

            estaTomado = false;
            transform.SetParent(null);

            if(rb != null)
            {
                rb.isKinematic = false;
            }
            if (dropZone != null)
            {
                transform.position = dropZone.position;
            }
            else
            {
                transform.position = posicionOriginal;
                transform.SetParent(padreOriginal);
            }

        }



    }



}
