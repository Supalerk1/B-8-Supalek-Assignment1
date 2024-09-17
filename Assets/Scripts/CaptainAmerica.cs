using UnityEngine;

public class CaptainAmericaMan : SuperHero
{
   
    //Behaviour
    public void LeapAndJump()
    {
        Debug.Log($"{Name} is LeapAndJump");
    }
    public void ThrowShield()
    {
        Debug.Log($"{Name} is ThrowShield");
    } 
}
