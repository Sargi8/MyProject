using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public PlayerControler Player;
    public Transform cube;


    private void Awake()
    {
        //нахождение плеера на сцене
        Player = GameObject.FindObjectOfType<PlayerControler>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cube.rotation = Quaternion.LookRotation(Player.transform.position - cube.position);
    }
}
