using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 20.0f;
    public float rotationSpeed = 20.0f;
    public float verticalInput;
    public float horizontalInput;
    public float rotateSpeed = 10.0f;
    public float startSpeed = 20f;
    public float boost;
    public float boostfactor;
    public bool Touchy;
    public GameObject Enemy;
    
    // Start is called before the first frame update
    void Start()
    {
        Touchy = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    
    
    if(Touchy == false){
        speed = startSpeed;
        speed = speed + (boost * boostfactor);


        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        boost = Input.GetAxis("Fire1");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right, rotationSpeed * verticalInput * Time.deltaTime);
        transform.Rotate(Vector3.forward, rotateSpeed * horizontalInput * Time.deltaTime);
    }
    }
}
