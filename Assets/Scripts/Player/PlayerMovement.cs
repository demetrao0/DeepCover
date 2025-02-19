
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController characterController;
    public float speed = 10f;

    public float gravity = -9.81f;


    public Transform groundCheck;
    public float sphereRadius = 0.3f;
    public LayerMask groundMask;

    public bool isGraunded;

    Vector3 velocity;

    // Update is called once per frame
    void Update()
    {

        isGraunded = Physics.CheckSphere(groundCheck.position, sphereRadius, groundMask);

        if (isGraunded && velocity.y < 0)
        {
            velocity.y = -2f;
        }


        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;


        characterController.Move(move*speed * Time.deltaTime);



        velocity.y += gravity * Time.deltaTime;

        characterController.Move(velocity * Time.deltaTime);


    }
}
