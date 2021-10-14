using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public PlayerControler Player;

    private void Awake()
    {
        //нахождение плеера на сцене
        Player = GameObject.FindObjectOfType<PlayerControler>(); 
    }

    void Start()
    {
        Debug.Log($"Hit {Player.name}"); //стрельба по плееру
    }

    void Update()
    {
        
    }
}
