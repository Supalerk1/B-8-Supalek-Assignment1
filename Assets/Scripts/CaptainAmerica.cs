using UnityEngine;

class CaptainAmericaMan : SuperHero
{
    public CaptainAmericaMan(string newName, int newHp, string newsuitColor) 
        : base(newName, newHp, newsuitColor)
    {
    }

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
