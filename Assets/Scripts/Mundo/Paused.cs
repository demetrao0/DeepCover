using UnityEngine;

public class Paused : MonoBehaviour
{
    public GameObject paused;
    public float numero;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        paused.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (numero == 0 && Input.GetKeyDown(KeyCode.Escape))
        {

            Time.timeScale = 0f;
            paused.SetActive(true);
            numero = 100f;

        }
        if (numero == 100f && Input.GetKeyDown(KeyCode.Return))
        {

            paused.SetActive(false);

            numero = 0f;

            Time.timeScale = 1f;

        }
    }
}
