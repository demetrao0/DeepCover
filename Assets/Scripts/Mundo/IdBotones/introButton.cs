using UnityEngine;
using UnityEngine.SceneManagement;

public class introButton : MonoBehaviour
{

    public string nameScene;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void Continuar()
    {
        SceneManager.LoadScene(nameScene);
    }
}
