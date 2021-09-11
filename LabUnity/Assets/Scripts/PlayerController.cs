using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.CodeEditor;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 6f;
    private float horizontalInput;
    private float verticalInput;

    private float zBound = 15;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Boundry();
    }

    private void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        rb.AddForce(Vector3.forward * speed * verticalInput);
        rb.AddForce(Vector3.right * speed * horizontalInput);
    }

    private void Boundry()
    {
        //Make a boundry so player do not fall out
        if (transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }

        if (transform.position.z > zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Player has collided with enemy");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Powerup"))
        {
            Destroy(other.gameObject);
        }
    }
}
