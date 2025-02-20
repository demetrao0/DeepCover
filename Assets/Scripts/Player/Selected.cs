using UnityEngine;

public class Selected : MonoBehaviour
{
    LayerMask mask;
    public float distance = 1.5f;

    public Texture2D puntero;
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
            if (hit.collider.tag == "Interactive")
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<InteractiveObject>().ActivarObjeto();
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
        transform.GetComponent<MeshRenderer>().material.color = Color.green;
        ultimoReconocido = transform.gameObject;
    }


    void Deselect()
    {
        if (ultimoReconocido)
        {
            ultimoReconocido.GetComponent<Renderer>().material.color = Color.white;
            ultimoReconocido = null;

        }
    }

    private void OnGUI()
    {
        Rect rect = new Rect(Screen.width / 2, Screen.height / 2, puntero.width, puntero.height);
        GUI.DrawTexture(rect, puntero);

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
