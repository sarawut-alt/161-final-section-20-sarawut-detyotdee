using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    // Start is called before the first frame update
    void Start()
    {
        Cast("snake");
        Cast("snake",6);

    }

    public override void Cast()
    {
        Debug.Log($"Casting Fire  spell to burn enemy.");
    }
}
