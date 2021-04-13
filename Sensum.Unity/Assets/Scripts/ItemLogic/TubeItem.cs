using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeItem : MonoBehaviour , Iitem
{

   [SerializeField,Range(0,100)] float _volume;
   [SerializeField] LiquidType _liquid; 
   [SerializeField,Range(1,10)] float  _speedOFFlow; 
    [SerializeField, Range(1, 10)] float _density;

    #region fields innit part 
    public float GetVolume()
    {
        return _volume;
    }
    public void SetLiquid(LiquidType t, float volume , float speedOfFlow, float density)
    {
        _liquid = t;
        _volume = volume;
        _speedOFFlow = speedOfFlow;
        _density = _density;
    }
    #endregion
    public void Attach()
    {
        throw new System.NotImplementedException();
    }

    public bool CanRender()
    {
        throw new System.NotImplementedException();
    }

    public void Deatach()
    {
        throw new System.NotImplementedException();
    }

    public void Dipose()
    {
        throw new System.NotImplementedException();
    }

    private void Update()
    {
        RenderVolume();
    }

    private void RenderVolume()
    {
        throw new NotImplementedException();
    }
}
