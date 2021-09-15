using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    
    //ENCAPSULATION
    private string name; // field
    private Color color; // field

    public string Name   // property
    {
        get { return name; }   // get method
        set { name = value; }  // set method
    }
    
    public Color Color
    {
        get { return color; } 
        set { color = value; }
    }
    
    public virtual void DisplayText()
    {
        Debug.Log("Base Display");
    }
}
