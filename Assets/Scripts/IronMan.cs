using UnityEngine;

class IronMan
{
    //Attributes
    public string Name;
    public int Hp;
    public string SuitColor;
    private float armorSTR;

    // Constructor
    public IronMan(string newName, int newHp, string newsuitColor)
    {
        Name = newName;
        Hp = newHp;
        SuitColor = newsuitColor;
        armorSTR = 10;
    }

    public void Fly()
    {
        Debug.Log($"{Name} is fly");
    }
    public void Shootlaser()
    {
        Debug.Log($"{Name} is shootlaser");
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