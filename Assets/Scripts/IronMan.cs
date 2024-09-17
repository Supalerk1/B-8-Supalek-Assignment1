using UnityEngine;

class IronMan : SuperHero
{
    public IronMan(string newName, int newHp, string newsuitColor) 
        : base(newName, newHp, newsuitColor)
    {
    }   
       
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