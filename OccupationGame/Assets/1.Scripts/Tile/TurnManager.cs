using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    public UnitOccupation Occupation;



    public void Start()
    {
        
    }

    public void TurnEnd()
    {
        Occupation = FindObjectOfType<UnitOccupation>();    
        Occupation.TurnEnd();
        
    }

    
}
