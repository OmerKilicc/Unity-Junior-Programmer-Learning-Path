﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CongratScript : MonoBehaviour
{
    public TextMesh Text;
    public ParticleSystem SparksParticles;

    List<string> TextToDisplay = new List<string>();
    


    private float TimeToNextText;
    private float RotationSpeed;
    
    private int CurrentText;

    // Start is called before the first frame update
    void Start()
    {
        
        TimeToNextText = 0.0f;
        CurrentText = 0;
        RotationSpeed = 1.0f;
        TextToDisplay.Add("Congratulation");
        TextToDisplay.Add("All Errors Fixed");
        Text.text = TextToDisplay[CurrentText];

        SparksParticles.Play();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,RotationSpeed,0);
        TimeToNextText += Time.deltaTime;

        if (TimeToNextText > 1.5f)
        {
            TimeToNextText = 0.0f;
            CurrentText++;
            if (CurrentText >= TextToDisplay.Count)
            {
                
                CurrentText = 0;
            }
            Text.text = TextToDisplay[CurrentText];
        }
    }
}