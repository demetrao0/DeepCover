using UnityEngine;

public class PalancaInteractive : MonoBehaviour
{


    public GameObject Player;
    public GameObject anim;

    public void ActivarObjeto()
    {
        anim.GetComponent<Anim>().Animacion();

        Player.GetComponent<Victory>().AliensLibres();


        //Destroy(gameObject);
    }
}
