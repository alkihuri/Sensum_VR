﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ChildObjectFucker : MonoBehaviour
{
    [SerializeField] PhotonView pv;
    [SerializeField] bool mode;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(pv.IsMine && mode);
    }
 
}
