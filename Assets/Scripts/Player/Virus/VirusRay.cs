using UnityEngine;

public class VirusRay : MonoBehaviour
{
    public LayerMask mask;
    public float distance = 1.7f;
    public GameObject TextoDetect;
    private GameObject objetoTomado = null;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        mask = LayerMask.GetMask("Interactive");
        TextoDetect.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;

        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, distance, mask))
        {

            if (Input.GetKeyDown(KeyCode.E))
            {
                if (objetoTomado == null && hit.collider.CompareTag("Virus"))
                {

                    objetoTomado = hit.collider.gameObject;
                    objetoTomado.GetComponent<VirusCom>().TomarObjeto(transform);

                }
                else if (objetoTomado != null)
                {
                    Transform dropZone = null;
                    if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hitDrop, distance, mask))
                    {

                        if (hitDrop.collider.CompareTag("DropZone"))
                        {

                            dropZone = hitDrop.transform;

                        }

                    }

                    objetoTomado.GetComponent<VirusCom>().soltarObjeto(dropZone);
                    objetoTomado = null;

                }

            }

        }


    }
}
