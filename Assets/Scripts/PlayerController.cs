using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    [SerializeField] private float turnSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward *Time.deltaTime * speed * Input.GetAxis("Vertical")); //Time.deltaTime = control the time not relying on frame //but why do we seperate it from frame rate you may ask
                                                                                                                       //because we dont know how fast is the computer is going to render it
                                                                                                                      //so we use delta time to make sure it moves at the same speed on all
       

        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * Input.GetAxis("Horizontal"));
        //this rotates the car smoothly left and right
        //and for this i deleted this line of code : transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * Input.GetAxis("Horizontal"));








        //Input.GetAxis("Horizontal") = get input from the horizontal axis (left/right arrow keys or A/D keys)
        //Vector3.right = (1, 0, 0)

        //vector3.forward = (0, 0, 1)
    }//transform = unity's way of representing position, rotation, and scale of an object in 3D space
    //translate = method that moves the object in a specified direction (telling computer to move object)


    //there is a weird method first you make [SerializedField] private float forawrdInput;
    //then come to the update methotd and write forwardInput = Input.GetAxis("Vertical"); 
    //after that you write transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput); 
    //this is another way of doing the same thing as above and yes its more organized but i think its unnecessary
}
