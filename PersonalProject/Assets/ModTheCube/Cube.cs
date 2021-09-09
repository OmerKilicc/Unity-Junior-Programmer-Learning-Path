using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Cube : MonoBehaviour
{
    public Color startColor;
    public Color finishColor;
    public float speed = 1f;
    public bool repeatable = false;

    private float randomSize;
    private float randomRotation;
    private float startTime;

    void Start()
    {
        startTime = Time.time;
        randomSize = Random.Range(1f, 2f);
        randomRotation = Random.Range(0f, 50f);
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * randomSize;

    }

    void Update()
    {
        transform.Rotate(randomRotation * Time.deltaTime, 
            randomRotation * Time.deltaTime, 
            randomRotation * Time.deltaTime);

        if (!repeatable)
        {
            float t = (Time.time - startTime) * speed;
            GetComponent<Renderer>().material.color = Color.Lerp(startColor, finishColor, t);
        }
        else
        {
            float t = (Mathf.Sin(Time.time - startTime) * speed);
            GetComponent<Renderer>().material.color = Color.Lerp(startColor, finishColor, t);
        }
        
    }
}
