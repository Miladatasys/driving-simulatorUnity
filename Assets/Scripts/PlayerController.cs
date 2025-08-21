using UnityEngine;

public class PlayerController : MonoBehaviour
{   

    // Player movement
    private float speed = 15.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;

    // Switch camera
    public Camera mainCamera;
    public Camera hoodCamera;
    public KeyCode switchKey;

    // Local Multiplayer
    public string inputID;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" + inputID);

        // We move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Rotates the car based on horizontal Input
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
        // Switch camera
        if(Input.GetKeyDown(switchKey))
        {
            mainCamera.enabled = !mainCamera.enabled;
            hoodCamera.enabled = !hoodCamera.enabled;
        }

    }
}
