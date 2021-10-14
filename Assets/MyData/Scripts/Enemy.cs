using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public PlayerControler Player;

    private void Awake()
    {
        //���������� ������ �� �����
        Player = GameObject.FindObjectOfType<PlayerControler>(); 
    }

    void Start()
    {
        Debug.Log($"Hit {Player.name}"); //�������� �� ������
    }

    void Update()
    {
        
    }
}
