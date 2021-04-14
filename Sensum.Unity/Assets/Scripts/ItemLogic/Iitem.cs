using System;
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

public class Liquid
{
    public LiquidType _liquidType; 
    [SerializeField, Range(1, 10)] float _speedOFFlow;
    [SerializeField, Range(1, 10)] float _density; 
    // класс знает только про свой volume, про volume всей пробирки он не знает
    [SerializeField, Range(0, 100)] float _volume; 
    public Liquid()
    {
        _speedOFFlow = 1;
        _density = 1;
        _volume = 1;
        _liquidType = LiquidType.water; 
    }
    
    public float GetVolume()
    {
        return _volume;
    }
    public void AddVolume(float amount)
    {
        _volume += amount;
    }

    
    public Liquid(string type  )
    {
        switch(type)
        {
            case "Water":
                _speedOFFlow = 3;
                _density = 1;
                _volume = 0;
                _liquidType = LiquidType.water;
            break;
            case "Oil":
                _speedOFFlow = 2;
                _density = 2;
                _volume = 0;
                _liquidType = LiquidType.oil;
            break;
            case "Mercury": 
                _speedOFFlow = 1;
                _density = 3;
                _volume = 0;
                _liquidType = LiquidType.mercury;
            break;

            default: 
                _speedOFFlow = 1;
                _density = 1;
                _volume = 0;
                _liquidType = LiquidType.water;
                Debug.Log("Shit format of liquid, bruh");
            break;
        }
       
    }

    internal void SetVolume(float value) // не безопастная  шляпа, да и X с ней пусть будет
    {
        _volume = value; 
    }
}