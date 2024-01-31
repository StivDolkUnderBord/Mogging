using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class GameLoopManager : MonoBehaviour
{
    public bool LoopShouldEnd;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    IEnumerator GameLoop()
    {
        while (LoopShouldEnd == false) 
        {

            //Spawn Enemies

            //Spawn Towers

            //Move Enemies

            //Tick Towers

            //Apply Effects

            //Damage Enemies 

            //Remove Enemies

            //Remove Towers

            yield return null;

        }

    }
  
}
