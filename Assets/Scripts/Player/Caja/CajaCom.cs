using UnityEngine;

public class CajaCom : MonoBehaviour
{
    public GameObject Player;
    public GameObject anim;

   public void ActivarObjeto()
    {
        anim.GetComponent<AnimCaja>().Animacion();
        
    }

   
}
