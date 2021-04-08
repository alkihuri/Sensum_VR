using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }
}

public class PlayerPresenter
{
    private PlayerView _playerView;
    private PlayerModel _playerModel;

    public PlayerPresenter(PlayerView view, PlayerModel model)
    {
        _playerView = view;
        _playerModel = model;
    }
}

public class PlayerModel
{
    
}