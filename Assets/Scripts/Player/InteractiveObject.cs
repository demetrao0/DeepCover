using UnityEngine;

public class InteractiveObject : MonoBehaviour
{

    public GameObject Player;
    public GameObject spaawn;



   public void ActivarObjeto()
    {


        gameObject.transform.position = spaawn.transform.position;

        //Player.GetComponent<PlayerMovement>().LLaveOn();
       

        //Destroy(gameObject);
    }
}