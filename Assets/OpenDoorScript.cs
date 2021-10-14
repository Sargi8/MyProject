using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoorScript : MonoBehaviour
{
    public Transform _player;
    public Transform door;
    public float speedRotation;

    private void FixedUpdate()
    {
        if(_player != null) 
        {
            Vector3 stepDirection = Vector3.RotateTowards(door.forward, Vector3.back, speedRotation * Time.fixedDeltaTime, 0.0f);
            door.rotation = Quaternion.LookRotation(stepDirection);
        }
        else
        {
            Vector3 stepDirection = Vector3.RotateTowards(door.forward, Vector3.forward, speedRotation * Time.fixedDeltaTime, 0.0f);
            door.rotation = Quaternion.LookRotation(stepDirection);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _player = other.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _player = null;
        }
    }
}
