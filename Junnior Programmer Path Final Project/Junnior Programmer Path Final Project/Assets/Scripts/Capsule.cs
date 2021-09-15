using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class Capsule : Shape
{
    private void Start()
    {
        Shape shape = GameObject.Find("GameManager").GetComponent<Shape>();
        shape.Name = "Capsule";
        shape.Color = Color.red;
    }
    
    
    //Polymorphism
    public override void DisplayText()
    {
        base.DisplayText();
        Debug.Log("Capsule clicked");
        Debug.Log(Name + Color);
    }

    private void OnMouseDown()
    {
        //Abstraction
        DisplayText();
    }
}
