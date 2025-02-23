using UnityEngine;

public class Victory : MonoBehaviour
{



    public bool Aliens = false;
    public bool llaveCaja = false;
    public bool llaveBoton = false;
    public bool virus = false;

    public float victory = 0f;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void AliensLibres()
    {
        Aliens = true;
        victory = victory + 100f;
    }


    public void Llave()
    {
        llaveCaja = true;
    }

    public void LlaveBoton()
    {
        llaveBoton = true;
    }

    public void Virus()
    {

        virus = true;
        victory = victory + 100f;

    }


}
