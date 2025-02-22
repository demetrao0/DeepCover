using UnityEngine;
using UnityEngine.SceneManagement;

public class introButton : MonoBehaviour
{

    public string nameScene;

  public void Continuar()
    {
        SceneManager.LoadScene(nameScene);
    }
}
