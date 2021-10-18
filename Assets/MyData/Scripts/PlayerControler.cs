using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    public CharacterController controller;
    public Transform groundchek;
    public LayerMask groundMask;

    public float movespeed;
    public float gravity = -9.8f;
    Vector3 velocity;
    public float groundDistance = 0.4f;

    public float jumpHeight = 3f;

    public GameObject BulletPrefab;
    public Transform spawnBulletPoint;
    private bool _isFire;
    public float damage;
    public Transform _enemy;
    public float bulletSpeed;

    bool isGrounded;

    private void Fire()
    {
        GameObject bulletObject = Instantiate(BulletPrefab, spawnBulletPoint.position, transform.rotation);
        BulletScript bullet = bulletObject.transform.gameObject.GetComponent<BulletScript>();
        bullet.Initialization(damage, 3f, bulletSpeed, _enemy);

    }

    private void Awake()
    {
        damage = 4;
    }

    private void Update()
    {
        isGrounded = Physics.CheckSphere(groundchek.position, groundDistance, groundMask);
        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        if (Input.GetMouseButtonDown(0)) 
        { 
            _isFire = true; 
        }
            

    }

    void FixedUpdate()
    {
        float Hor = Input.GetAxis("Horizontal");
        float Ver = Input.GetAxis("Vertical");

        Vector3 move = transform.right * Hor + transform.forward * Ver;
        controller.Move(move * movespeed * Time.fixedDeltaTime);

        if (_isFire)
        {
            _isFire = false;
            Fire();
        }



    }
}
