using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{
    private float side = 4;


    private void Start()
    {
        Init("Square");
        Draw();
        base.Resize();
        Resize();
        Debug.Log($"{shapeName} area is {CalculateArea()}");
    }

    public override float CalculateArea()
    {

        return side * side;
        

    }
    public override void Resize()
    {
        Debug.Log($"{shapeName} is resized");
        Debug.Log($"{shapeName} side: {side}");
    }

}
