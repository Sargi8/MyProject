using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float _damage;
    public float speed = 100f;
    

    private void FixedUpdate()
    {
        
         //transform.Translate(transform.forward * speed * Time.fixedDeltaTime);
        //Vector3 direction = transform.forward * _speed * Time.fixedDeltaTime;
       Vector3 direction = transform.forward * speed * Time.fixedDeltaTime;

        transform.position += direction;
    } 

    //метод по уничтожению снарядов
    public void Initialization(float damage, float lifeTime)
    {
        _damage = damage;
        Destroy(this.gameObject, lifeTime); 
    }
}
