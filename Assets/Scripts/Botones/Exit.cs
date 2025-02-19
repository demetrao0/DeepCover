using UnityEngine;

public class Exit : MonoBehaviour
{
   
    public void Close()
    {
        Debug.Log("El juego se cerró");
        Application.Quit();
    }



}
