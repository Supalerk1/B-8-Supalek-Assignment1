using UnityEngine;

public class IronMan : SuperHero
{
    
    //Behaviour
    public void Fly()
    {
        Debug.Log($"{Name} is Fly");
    }
    public void Shootlaser()
    {
        Debug.Log($" {Name}is Shoot Laser");
    }
}