using UnityEngine;

public class InteractivePalanca : MonoBehaviour
{
    public GameObject Player;
    public GameObject anim;
    public bool prueba = false;
    public void ActivarObjeto()
    {


        //gameObject.transform.position = spaawn.transform.position;

        anim.GetComponent<Anim>().Animacion();  

        Player.GetComponent <Victory>().AliensLibres();


        Destroy(gameObject);
    }


}
