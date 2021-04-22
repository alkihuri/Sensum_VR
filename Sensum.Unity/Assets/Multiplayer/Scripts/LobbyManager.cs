using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class LobbyManager : MonoBehaviourPunCallbacks
{
    [SerializeField] string MVPSceneName = "1stLessonMVP";
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.NickName = "BULSHITPLAYER_" + Random.Range(1000, 9999);
        PhotonNetwork.GameVersion = "1";
        PhotonNetwork.AutomaticallySyncScene = false;
        if(!PhotonNetwork.IsConnectedAndReady)
            PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Conecceted!");
        if(PhotonNetwork.CountOfRooms>0)
        {
            PhotonNetwork.JoinRoom(PlayerPrefs.GetString("RoomName"));
        }
         else
        {
            PhotonNetwork.CreateRoom(PlayerPrefs.GetString("RoomName"));
        }
    }

    public override void OnCreatedRoom()
    {
        PhotonNetwork.JoinRoom(PlayerPrefs.GetString("RoomName"));
    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel(MVPSceneName);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
