using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadEscene : MonoBehaviour
{
    public string sceneName;

    public void LoadScene()
    {

        SceneManager.LoadScene(sceneName);


    }
  



}
