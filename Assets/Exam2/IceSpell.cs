using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpell : Spell
{
    // Start is called before the first frame update
    void Start()
    {
        Cast("Goblin");
        Cast("Goblin",2);

    }
    public override void Cast()
    {
        Debug.Log($"Casting Ice  spell to Frezze enemy.");
    }

}
