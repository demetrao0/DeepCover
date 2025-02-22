using UnityEngine;

public class LaysRay : MonoBehaviour
{

    public LayerMask mask;
    public float distance = 1.5f;
    public GameObject TextoDetect;
    private GameObject objetoTomado = null;

    void Start()
    {
        mask = LayerMask.GetMask("Interactive");
        TextoDetect.SetActive(false);
    }

    void Update()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, distance, mask))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (objetoTomado == null && hit.collider.CompareTag("Lays"))
                {
                    // Tomar el objeto
                    objetoTomado = hit.collider.gameObject;
                    objetoTomado.GetComponent<LaysCom>().TomarObjeto(transform);
                }
                else if (objetoTomado != null)
                {
                    // Buscar DropZone para soltar el objeto
                    Transform dropZone = null;
                    if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hitDrop, distance, mask))
                    {
                        if (hitDrop.collider.CompareTag("DropZone"))
                        {
                            dropZone = hitDrop.transform;
                        }
                    }

                    // Soltar el objeto
                    objetoTomado.GetComponent<LaysCom>().SoltarObjeto(dropZone);
                    objetoTomado = null;
                }
            }
        }

        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * distance, Color.red);
    }




}
