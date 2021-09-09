using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float thrustSpeed;
    [SerializeField] private float turnSpeed;

    private float horizontalInput;
    private float verticalInput;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //Move the vehicle forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * thrustSpeed * verticalInput);
        
        //Rotate the vehicle left-right based on horizontalInput
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

    }
}
