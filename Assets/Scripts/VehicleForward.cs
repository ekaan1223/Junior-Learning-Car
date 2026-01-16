using UnityEngine;

public class VehicleForward : MonoBehaviour
{
    [SerializeField] private float speed = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
