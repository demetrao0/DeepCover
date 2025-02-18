using UnityEngine;

public class CameraLook : MonoBehaviour
{

    public float mouseSensivity = 80f;
    public Transform playerBody;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;

        float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;


        playerBody.Rotate(Vector3.up * mouseX);

    }
}
