using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Shape : MonoBehaviour
{
    protected string shapeName;


    public void Init(string newShapeName)
    {
        shapeName = newShapeName;
    }

    public abstract float CalculateArea();
    public virtual void Resize()
    {
        Debug.Log($"Resizing Shape...");
    }
    public void Draw()
    {
        Debug.Log($"Drawing {shapeName}");
    }
}
