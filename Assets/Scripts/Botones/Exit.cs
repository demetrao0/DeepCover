using UnityEngine;

public class Exit : MonoBehaviour
{
   
    public void Close()
    {
        Debug.Log("El juego se cerr�");
        Application.Quit();
    }



}
