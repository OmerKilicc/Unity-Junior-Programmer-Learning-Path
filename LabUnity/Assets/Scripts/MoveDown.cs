using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    private Rigidbody enemyRigidbody;
    private float zDestroy = -10;
    [SerializeField] private float speed;
    // Start is called before the first frame update
    void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        enemyRigidbody.AddForce(Vector3.back * speed * Time.deltaTime);
        if (transform.position.z < zDestroy)
        {
            Destroy(gameObject);
        }
    }

  
}
