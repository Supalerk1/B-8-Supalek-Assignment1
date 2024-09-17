using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class Main : MonoBehaviour
{  
    public IronMan ironMan ;
    public CaptainAmericaMan CaptainAmericaMan;

    // Start is called before the first frame update
    void Start()
    {
       ironMan.Name = "";

        //Show Attribut
        Debug.Log($"IronMan name: {ironMan.Name}, Hp: {ironMan.Hp}, colorl: {ironMan.SuitColor}");
        Debug.Log($"CaptainAmericaMan name: {CaptainAmericaMan.Name},Hp: {CaptainAmericaMan.Hp},color:{CaptainAmericaMan.SuitColor}");
        
        ironMan.UpdateArmorStrength(5.25f);
        CaptainAmericaMan.UpdateArmorStrength(5.25f);

    }

   private void update()
    {
        if( ironMan.Isdead() || CaptainAmericaMan.Isdead())
        {
            return;
        }

        //ironman >damage
        CaptainAmericaMan.TaskDamage((int)Random.Range(10, 20f));
        ironMan.Fly();
        ironMan.Shootlaser();
            
        //CAPITÃO >damage
        ironMan.TaskDamage((int)Random.Range(10f, 20f));
        CaptainAmericaMan.LeapAndJump();
        CaptainAmericaMan.ThrowShield();
            
    }
}
