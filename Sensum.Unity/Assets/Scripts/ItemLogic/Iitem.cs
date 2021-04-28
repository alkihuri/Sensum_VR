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
    [SerializeField, Range(1, 10)] float _density;// плотность
    // класс знает только про свой volume, про volume всей пробирки он не знает
    [SerializeField] Color _volumeColor;
    [SerializeField, Range(0.1f,0.2f)] public float height;//м^3
    public Liquid()
    {
        _density = 997;
        _volumeColor = Color.blue;
        _liquidType = LiquidType.water; 
    }

    public float GetHeight(){
        return height*100;
    }
    public Liquid(string type)
    {
        switch(type)
        {
            case "Water":
                height = 0.1f;
                _density = 1;
                _volumeColor = Color.blue;
                _liquidType = LiquidType.water;
            break;
            case "Oil":
                _density = 2;
                _volumeColor = Color.yellow;
                _liquidType = LiquidType.oil;
            break;
            case "Mercury":
                _density = 3;
                _volumeColor = Color.black;
                _liquidType = LiquidType.mercury;
            break;

            default:
                _density = 997;
                _volumeColor = Color.blue;
                _liquidType = LiquidType.water;
                Debug.Log("Shit format of liquid, bruh");
            break;
        }
       
    }
}
