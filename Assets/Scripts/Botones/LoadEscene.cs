using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadEscene : MonoBehaviour
{
    public string sceneName;

    public GameObject Controles;
    public GameObject Creditos;


    private void Start()
    {

        Controles.SetActive(false);
        Creditos.SetActive(false);

    }

    public void ControlesOn()
    {

        Controles.SetActive(true);

    }

    public void CreditosOn()
    {

        Creditos.SetActive(true);

    }


    public void CreditosOff()
    {

        Creditos.SetActive(false);

    }

    public void ControlesOff()
    {

        Controles.SetActive(false);

    }

    public void LoadScene()
    {

        SceneManager.LoadScene(sceneName);


    }
  



}
