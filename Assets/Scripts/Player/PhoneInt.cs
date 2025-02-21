using UnityEngine;

public class PhoneInt : MonoBehaviour
{
    LayerMask mask;
    public float distance = 1.5f;

    
    public GameObject TextoDetect;
    GameObject ultimoReconocido = null;


    public Texture main;
    public Texture activ;




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


        Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * distance, Color.yellow);


        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, distance, mask))
        {
            Deselect();
            SelectedObject(hit.transform);
            if (hit.collider.tag == "Telefono")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<InteractivePhone>().ActivarObjeto();
                }
            }
            //Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * distance, Color.red);

        }
        else
        {
            Deselect();
        }



    }



    void SelectedObject(Transform transform)
    {
        transform.GetComponent<MeshRenderer>().material.mainTexture = activ;
        ultimoReconocido = transform.gameObject;
    }


    void Deselect()
    {
        if (ultimoReconocido)
        {
            ultimoReconocido.GetComponent<Renderer>().material.mainTexture = main;
            ultimoReconocido = null;

        }
    }

    private void OnGUI()
    {
        //Rect rect = new Rect(Screen.width / 2, Screen.height / 2, puntero.width, puntero.height);
        //GUI.DrawTexture(rect, puntero);

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
