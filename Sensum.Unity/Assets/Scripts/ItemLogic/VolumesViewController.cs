﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using LiquidVolumeFX;
public class VolumesViewController : MonoBehaviour
{
    [SerializeField] GameObject _luquidGameObject;
    [SerializeField] LiquidVolume _liquidVolume;
    Liquid l;
    public List<float> addVolumes = new List<float>();
    //Все данные измеряются в см.
    private float volume;
    private float rad = 0.2f;
    private float height = 0.25f;
    private void Awake()
    {
        l= new Liquid("Water");
        SetView(l); 
    }
    void Start()
    {
        volume = 3.14f * rad *rad* height;
    }

    public void SetView(Liquid water)
    {
        Debug.Log(l._liquidType);
        #region тупо хаrд код шляпа, нужен будет нормально рендер но пока и так сойдет
        //Находит высоту, на которую исходя из объёма получаемого объекта должен подняться уровень жидкости.
        _luquidGameObject.transform.localScale = new Vector3(rad, height, rad);
        if(addVolumes.Count<1)
            _liquidVolume.level = (water.GetHeight()) / 25; //total level
        else
        {
            float prevVolume = (water.GetHeight()/100)*3.14f*rad*rad;
            for(int i = 0; i < addVolumes.Count; i++)
            {
                prevVolume += addVolumes[i];
            }
            float prevVolumeHeight = prevVolume / (3.14f * rad * rad);
            DOTween.To(() => _liquidVolume.level, x => _liquidVolume.level = x, prevVolumeHeight*100f/25f, 1f);
        }
        #endregion
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PhysItem>())
        {
            addVolumes.Add(other.gameObject.GetComponent<PhysItem>().PreVolume);
            SetView(l);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<PhysItem>())
        {
            addVolumes.Remove(other.gameObject.GetComponent<PhysItem>().PreVolume);
            SetView(l);
        }
    }
}
