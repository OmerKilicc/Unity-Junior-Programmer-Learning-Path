using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float speed;
    
    private GameObject player;
    private Rigidbody enemyRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRigidbody.AddForce(lookDirection * speed);

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
    
    
}
