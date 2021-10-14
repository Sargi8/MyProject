using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public Transform _player;
    public Transform Floor1;
    public Transform Floor2;
    public float speedRotation;

    private void FixedUpdate()
    {
        if (_player != null)
        {
            Vector3 stepDirection = Vector3.RotateTowards(Floor1.forward, Vector3.up, speedRotation * Time.fixedDeltaTime, 0.0f);
            Floor1.rotation = Quaternion.LookRotation(stepDirection);
            Vector3 stepDirection1 = Vector3.RotateTowards(Floor2.forward, Vector3.down, speedRotation * Time.fixedDeltaTime, 0.0f);
            Floor2.rotation = Quaternion.LookRotation(stepDirection1);
        }
        else
        {
            Vector3 stepDirection = Vector3.RotateTowards(Floor1.forward, Vector3.forward, speedRotation * Time.fixedDeltaTime, 0.0f);
            Floor1.rotation = Quaternion.LookRotation(stepDirection);
            Vector3 stepDirection1 = Vector3.RotateTowards(Floor2.forward, Vector3.forward, speedRotation * Time.fixedDeltaTime, 0.0f);
            Floor2.rotation = Quaternion.LookRotation(stepDirection1);
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
