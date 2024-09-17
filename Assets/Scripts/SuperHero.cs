using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperHero
{
    //Attributes
    public string Name;
    public int Hp;
    public string SuitColor;
    private float armorSTR;

    // Constructor
    public SuperHero(string newName, int newHp, string newsuitColor)
    {
        Name = newName;
        Hp = newHp;
        SuitColor = newsuitColor;
        armorSTR = 10;
    }

    public void UpdateArmorStrength(float strength)
    {
        armorSTR += strength;
        Debug.Log($"{Name} updated their STR is {armorSTR}");

    }
    // Dead
    public bool Isdead()
    {
        if (Hp <= 0)
        {
            return true;
        }
        else return false;
    }
    // DamegeKUb
    public void TaskDamage(int damege)
    {
        if (!Isdead())
        {
            Hp -= damege;
            Debug.Log($"{Name} take {damege}Damage:");
        }
        else
        {
            Debug.Log($"{Name} is dead");
        }
    }
}
