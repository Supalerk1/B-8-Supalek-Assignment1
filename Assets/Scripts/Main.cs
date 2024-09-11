using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        IronMan ironMan = new IronMan("Tony", 100, "Red");
        ironMan.UpdateArmorStrength(5.25f);
        CaptainAmericaMan captainAmericaMan = new CaptainAmericaMan("CAPITÃO", 100, "Bule");
        captainAmericaMan.UpdateArmorStrength(5.25f);


        for (var i = 0; i < 5; i++)
        {
        
            Debug.Log($"IronMan name: {ironMan.Name}, Hp: {ironMan.Hp}, colorl: {ironMan.SuitColor}");
            

            //ironman >damage
            ironMan.Fly();
            ironMan.Shootlaser();
            captainAmericaMan.TaskDamage((int)Random.Range(10f, 20f));

            Debug.Log($"CaptainAmericaMan name: {captainAmericaMan.Name},Hp: {captainAmericaMan.Hp},color: {captainAmericaMan.SuitColor}");
            

            //CAPITÃO >damage
            captainAmericaMan.LeapAndJump();
            captainAmericaMan.ThrowShield();
            ironMan.TaskDamage((int)Random.Range(10f, 20f));

        }

       
    }


}
