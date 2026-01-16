using Unity.VisualScripting;
using UnityEngine;

public class FirstPerson : MonoBehaviour
{
    public GameObject player; // Reference to the player object
    private Vector3 offset = new Vector3(0, 2, 1);

    private void FPS()
    {
        transform.position = player.transform.position + offset;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            FPS();
        }
        else
        {
            transform.position = player.transform.position + new Vector3(0, 6, -9);
        }
    }
}
