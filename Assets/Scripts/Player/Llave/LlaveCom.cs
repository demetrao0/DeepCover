using UnityEngine;

public class LlaveCom : MonoBehaviour
{
    public GameObject Player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    

    // Update is called once per frame
    public void ActivarObjeto()
    {
        Player.GetComponent<Victory>().Llave();
        Destroy(gameObject);
    }
}
