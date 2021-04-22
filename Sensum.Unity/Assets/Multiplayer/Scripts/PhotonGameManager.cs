using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotonGameManager : MonoBehaviour
{
    [SerializeField]
    List<Transform> spawnPoints = new List<Transform>();
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.Instantiate("Player", spawnPoints[Random.RandomRange(0,spawnPoints.Count-1)].position, Quaternion.identity);
    }
 
}
