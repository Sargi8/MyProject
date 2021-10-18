using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BulletScript : MonoBehaviour
{
    public float _damage;
    public float _bulletSpeed;
    private Transform _target;
    private Rigidbody _rb;
    private Vector3 _targetPosition;
    

    

    
    public void Initialization(float damage, float lifeTime, float speed, Transform target)
    {
        _rb = GetComponent<Rigidbody>();

        _bulletSpeed = speed;
        _target = target;
        _targetPosition = _target.position;
        _damage = damage;
        Destroy(this.gameObject, lifeTime);

        _rb.AddForce(transform.forward * _bulletSpeed);

    }

    private void FixedUpdate()
    {
        
        //transform.Translate(transform.forward * speed * Time.fixedDeltaTime);
        //Vector3 direction = transform.forward * _speed * Time.fixedDeltaTime;
        //Vector3 direction = transform.forward * speed * Time.fixedDeltaTime;

        //transform.position += direction;
    }

}
