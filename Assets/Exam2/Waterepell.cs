using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waterepell : Spell
{
    // Start is called before the first frame update
    void Start()
    {
        Cast("slime");
        Cast("slime",10);
    }



        public override void Cast()
    {
        Debug.Log($"Casting Water  spell to drown enemy.");
    }
}   
   


    

