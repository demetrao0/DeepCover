using UnityEngine;

public class Victory : MonoBehaviour
{



    public bool Aliens = false;
    public bool llaveCaja = false;
    
    
    
    
    
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
    }


    public void Llave()
    {
        llaveCaja = true;
    }


}
