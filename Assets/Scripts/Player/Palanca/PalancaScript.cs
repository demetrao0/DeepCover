using UnityEngine;

public class PalancaScript : MonoBehaviour
{
    LayerMask mask;
    public float distance = 1.5f;

    
    public GameObject TextoDetect;
    GameObject ultimoReconocido = null;
    


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





        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, distance, mask))
        {
            Deselect();
            SelectedObject(hit.transform);
            if (hit.collider.tag == "Palanca")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<PalancaInteractive>().ActivarObjeto();
                }
            }
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * distance, Color.red);

        }
        else
        {
            Deselect();
        }



    }



    void SelectedObject(Transform transform)
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

    private void OnGUI()
    {
        

        if (ultimoReconocido)
        {
            TextoDetect.SetActive(true);
        }
        else
        {
            TextoDetect.SetActive(false);
        }

    }
}
