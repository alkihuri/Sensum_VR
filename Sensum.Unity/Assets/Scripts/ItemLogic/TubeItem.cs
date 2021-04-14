using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeItem : MonoBehaviour, Iitem
{

    [SerializeField] public Liquid _water; // я просто не хотел get set логику прописывать пох пусть так и будет
    [SerializeField] public Liquid _oil; // нах  безопастный код
    [SerializeField] public Liquid _mercury;
    [SerializeField] float _volumeOfThisTube;
    [SerializeField, Range(0, 1)] float _waterPreSettings; 
    [SerializeField, Range(0, 1)] float _mercuryPreSettings; 
    [SerializeField, Range(0, 1)] float _oilPreSettings;

    #region fields innit part 

    private void Awake()
    {
        _water = new Liquid("Water" );
        _oil = new Liquid("Oil" );
        _mercury = new Liquid("Mercury" );
    }
    #endregion

    private void Start()
    {
         
            _water.AddVolume(_waterPreSettings  );
            _oil.AddVolume(_oilPreSettings);
            _mercury.AddVolume(_mercuryPreSettings);
        
    }

    public bool Fill(float amount, Liquid temp)
    {
        bool isPosiible = temp.GetVolume() + amount < _volumeOfThisTube;
        if (isPosiible)
            temp.AddVolume(amount);
        return isPosiible;
    }
    public bool Dispense(float amount, Liquid temp)
    {
        bool isPosiible = temp.GetVolume() - amount > 0;
        if (isPosiible)
            temp.AddVolume(-amount);
        return isPosiible;
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
       // SyncVolumes();
        RenderVolume();
    }

    private void SyncVolumes()
    {
        _water.SetVolume(_waterPreSettings);
        _oil.SetVolume(_oilPreSettings);
        _mercury.SetVolume(_mercuryPreSettings);
    }

    private void RenderVolume()
    {
        GetComponentInChildren<VolumesViewController>().SetView(_water, _oil, _mercury);
    }
}
