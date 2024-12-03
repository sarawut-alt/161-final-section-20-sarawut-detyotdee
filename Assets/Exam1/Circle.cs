using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Circle : Shape
{

    private int radius = 6;

    private void Start()
    {
        Init("Circle");
        Draw();
        base.Resize();
        Resize();
        Debug.Log($"{shapeName} area is {CalculateArea()}");
    }

    public override float CalculateArea()
    {
        return (float)(3.14 * 2 * radius);

    }
    public override void Resize()
    {
        Debug.Log($"{shapeName} is resized");
        Debug.Log($"{shapeName} radius: {radius}");
    }
}
