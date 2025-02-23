using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Noticias : MonoBehaviour
{
    public GameObject noticia1;
    public GameObject noticia2;
    public GameObject noticia3;

    public float numero = 0f;

    public string escenaVictoria;
   

    // Update is called once per frame
    void Update()
    {

        if (noticia1.activeSelf)
        {

            if (Input.GetKeyDown(KeyCode.Return) && numero == 100f)
            {
                noticia1.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                numero = 0f;
            }

        }

        if (noticia2.activeSelf)
        {

            if (Input.GetKeyDown(KeyCode.Return)&& numero == 200f)
            {
                noticia2.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                numero = 0f;
            }

        }

        if (noticia3.activeSelf)
        {

            if (Input.GetKeyDown(KeyCode.Return) && numero == 300f)
            {
                noticia3.SetActive(false);
                Cursor.lockState = CursorLockMode.Locked;
                numero = 0f;
                SceneManager.LoadScene(escenaVictoria);
            }

        }





    }
}
