using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spell : MonoBehaviour
{
    
    public virtual void Cast()
    {
        Debug.Log($"Casting generic spell.");
    }
    public void Cast(string target)
    {
        Debug.Log($"Casting spell on target: {target}");
    }
    public void Cast(string target,int powerLevel)
    {
        Debug.Log($"casting spell on {target} with power level:{powerLevel}");
    }
}
