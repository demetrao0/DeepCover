using UnityEngine;

public class InteractivePhone : MonoBehaviour
{

    public float timePased = 0f;
    


    private void Update()
    {
        timePased = timePased + Time.deltaTime;




    }

    public void ActivarObjeto()
    {


        //gameObject.transform.position = spaawn.transform.position;

        //Player.GetComponent<PlayerMovement>().LLaveOn();


        Destroy(gameObject);
    }
}
