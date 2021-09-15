using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    private void Start()
    {
        Shape shape = GameObject.Find("GameManager").GetComponent<Shape>();
        shape.Name = "Cube";
        shape.Color = Color.blue;
    }
    
    
    //Polymorphism
    public override void DisplayText()
    {
        base.DisplayText();
        Debug.Log("Cube clicked");
        Debug.Log(Name + Color);
    }

    private void OnMouseDown()
    {
        //Abstraction
        DisplayText();
    }
}
