using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface  Iitem  
{
    void Attach();
    void Deatach();
    void Dipose();
    bool CanRender();
}

public enum LiquidType 
{
    water,
    oil,
    mercury
}
