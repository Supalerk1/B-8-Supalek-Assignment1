using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperHero
{
    //Attributes
    protected string name;
    public string Name 
    {
        get 
        {
            return name;
        }
        set 
        {
            if (value == null || value == "") 
            {
                value = "N/A";
            }
            name = value;
        }
    }

    protected int hp;
    public int Hp { get { return hp; }set { hp = value; } }

    protected string suitColor;
    public string SuitColor { get; private set; }

    private float armorStr;

    
    // Constructor
    public SuperHero(string newName, int newHp, string newsuitColor)
    {
        name = newName;
        hp = newHp;
        SuitColor = newsuitColor;
        armorStr = 10;
    }

    public void UpdateArmorStrength(float strength)
    {
        armorStr += strength;
        Debug.Log($"{name} updated their STR is {armorStr}");

    }
    // Dead
    public bool Isdead()
    {
        if (hp <= 0)
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
            hp -= damege;
            Debug.Log($"{name} take {damege}Damage:");
        }
        else
        {
            Debug.Log($"{name} is dead");
        }
    }
}
