using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

        public string escenarioCambio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void Yes()
    {
        SceneManager.LoadScene(escenarioCambio);

    
    {


    }

}

    public void No()
    {

        Debug.Log("Se cerro el juego");
        Application.Quit();

    }
}
