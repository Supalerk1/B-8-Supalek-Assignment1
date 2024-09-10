using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        IronMan ironMan = new IronMan("Tony",100,"Red");
        Debug.Log($"IronMan name: {ironMan.Name}, Hp: {ironMan.Hp}, colorl: {ironMan.SuitColor}");

        ironMan.Fly();
        ironMan.Shootlaser();
        ironMan.UpdateArmorStrength(5.25f);
    }
}
