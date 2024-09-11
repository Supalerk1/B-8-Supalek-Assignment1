using UnityEngine;

class CaptainAmericaMan
{
    //Attributes
    public string Name;
    public int Hp;
    public string SuitColor;
    private float armorSTR;

    // Constructor
    public CaptainAmericaMan(string newName, int newHp, string newsuitColor)
    {
        Name = newName;
        Hp = newHp;
        SuitColor = newsuitColor;
        armorSTR = 10;
    }

    public void LeapAndJump()
    {
        Debug.Log($"CAPITÃO is LeapAndJump");
    }
    public void ThrowShield()
    {
        Debug.Log($" CAPITÃO is ThrowShield");
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
    //Damage
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
