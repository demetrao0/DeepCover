using UnityEngine;
using UnityEngine.EventSystems;

public class CajaRay : MonoBehaviour
{

    public LayerMask mask;
    public float distance = 2f;
    public GameObject Textodetect;
    private GameObject ultimoReconocido = null;

    public Victory playerVictory;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        mask = LayerMask.GetMask("Interactive");
        Textodetect.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, distance, mask))
        {

            Deselect();
            SelectedObject(hit.transform);

            if (hit.collider.CompareTag("Caja") && Input.GetKeyDown(KeyCode.E))
            {
                
                if(playerVictory != null)
                {
                    if (playerVictory.llaveCaja) { 
                    hit.collider.transform.GetComponent<CajaCom>().ActivarObjeto();
                    }
                }
                else
                {
                    //texto de Necesitas la llave 
                }

            }

        }

        else
        {
            Deselect();
        }
    }

    void SelectedObject(Transform trasform)
    {

        ultimoReconocido = transform.gameObject;

    }

    void Deselect()
    {

        if (ultimoReconocido)
        {
            ultimoReconocido = null;
        }

    }

    
}
