using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Sphere : Shape
{
    private void Start()
    {
        Shape shape = GameObject.Find("GameManager").GetComponent<Shape>();
        shape.Name = "Sphere";
        shape.Color = Color.green;
    }
    
    
    //Polymorphism
    public override void DisplayText()
    {
        base.DisplayText();
        Debug.Log("Sphere clicked");
        Debug.Log(Name + Color);
    }

    private void OnMouseDown()
    {
        //Abstraction
        DisplayText();
    }
}
