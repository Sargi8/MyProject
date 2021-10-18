using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform spawnBulletPoint;
    private bool _isFire;
    public float damage;
    public Transform _enemy;

    private void Awake()
    {
        damage = 4;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            _isFire = true;
    }

    private void FixedUpdate()
    {
        if (_isFire)
        {
            _isFire = false;
            Fire();
        }
    }

    private void Fire ()
    {
        GameObject bulletObject = Instantiate(BulletPrefab, spawnBulletPoint.position, transform.rotation);
        BulletScript bullet = bulletObject.transform.gameObject.GetComponent<BulletScript>();
        bullet.Initialization(damage, 30f, 100f, _enemy);

    }


}
