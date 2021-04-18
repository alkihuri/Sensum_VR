using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeItem : MonoBehaviour, Iitem
{

    [SerializeField] public Liquid _water;
    [SerializeField] float _volumeOfThisTube;
    [SerializeField, Range(0, 1)] float _waterPreSettings;

    #region fields innit part 

    private void Awake()
    {
        _water = new Liquid("Water");
    }
    #endregion

    private void Start()
    {
    }

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
        GetComponentInChildren<VolumesViewController>().SetView(_water);
    }
}
