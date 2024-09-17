using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class Main : MonoBehaviour
{  
    IronMan ironMan = new IronMan("Tonny", 100, "Red");
    CaptainAmericaMan captainAmericaMan = new CaptainAmericaMan("CAPITÃO", 100, "Bule");

    // Start is called before the first frame update
    void Start()
    {
        ironMan.Name = "Non";

        //Show Attribut
        Debug.Log($"IronMan name: {ironMan.Name}, Hp: {ironMan.Hp}, colorl: {ironMan.SuitColor}");
        Debug.Log($"CaptainAmericaMan name: {captainAmericaMan.Name},Hp: {captainAmericaMan.Hp},color:{captainAmericaMan.SuitColor}");
        
        ironMan.UpdateArmorStrength(5.25f);
        captainAmericaMan.UpdateArmorStrength(5.25f);

    }

    private void Update()
    {
        if(ironMan.Isdead() || captainAmericaMan.Isdead())
        {
            return;
        }

        //ironman >damage
        captainAmericaMan.TaskDamage((int)Random.Range(10, 20f));
        ironMan.Fly();
        ironMan.Shootlaser();
            
        //CAPITÃO >damage
        ironMan.TaskDamage((int)Random.Range(10f, 20f));
        captainAmericaMan.LeapAndJump();
        captainAmericaMan.ThrowShield();
            
    }
}
