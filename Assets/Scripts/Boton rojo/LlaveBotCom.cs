using UnityEngine;

public class LlaveBotCom : MonoBehaviour
{
    public GameObject Player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created


    // Update is called once per frame
    public void ActivarObjeto()
    {
        Player.GetComponent<Victory>().LlaveBoton();
        Destroy(gameObject);
    }
}
