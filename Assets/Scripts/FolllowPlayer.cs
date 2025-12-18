using UnityEngine;

public class FolllowPlayer : MonoBehaviour
{
    public GameObject player; //reference to the player object
    private Vector3 offset = new Vector3(0, 6, -9); //offset position of the camera relative to the player
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        transform.position = player.transform.position + offset;                //the reason we added a new vector3 is to offset the camera position 
                                                                                //so its not directly on top of the player
                                                                                //and new vector3 means we are creating a new vector3 object

    }
}
