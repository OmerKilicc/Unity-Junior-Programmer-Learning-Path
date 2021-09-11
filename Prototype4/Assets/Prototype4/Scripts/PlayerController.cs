using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed;

    private float powerupStrength = 15.0f;

    private Rigidbody _rigidbody;
    private GameObject focalPoint;
    public GameObject powerupIndicator;
    
    Vector3 offset = new Vector3(0,-0.5f,0);
    private bool hasPowerup = false;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        _rigidbody.AddForce(focalPoint.transform.forward * forwardInput * speed * Time.deltaTime);
        powerupIndicator.transform.position = transform.position + offset;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Powerup"))
        {
            hasPowerup = true;
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdownRoutine());
            powerupIndicator.gameObject.SetActive(true);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy") && hasPowerup)
        {
            Rigidbody enemyRigidbody = other.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = (other.gameObject.transform.position - transform.position);
            enemyRigidbody.AddForce(awayFromPlayer * powerupStrength,ForceMode.Impulse);
        }
    }

    IEnumerator PowerupCountdownRoutine()
    {
        yield return new WaitForSeconds(7);
        hasPowerup = false;
        powerupIndicator.gameObject.SetActive(false);
    }
}
