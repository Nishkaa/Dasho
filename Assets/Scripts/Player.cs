using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using TMPro;
using UnityEngine.UI;
using System;
public class Player : MonoBehaviour
{
    public float vertical;
    public float horizontal;
    private Rigidbody2D Player2D;
    public float speed;
    public float height;
    public bool jump;
    public float jumpVelocity = 3f;
    public AudioSource Jump;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5f;
        height = 60f;
        jump = false;

        Player2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
        //left and right Pressing A or D
        horizontal = Input.GetAxisRaw("Horizontal");
        //up and down Pressing W or S

        //Move left or right
        if (horizontal > 0.1f || horizontal < -0.1f)
        {
            Player2D.AddForce(new Vector2(horizontal * speed, 0f), ForceMode2D.Impulse);
        }
        if (horizontal > 0.1f)
        {
            Vector3 eulerRotation = transform.rotation.eulerAngles;
            transform.rotation = Quaternion.Euler(eulerRotation.x, 0, eulerRotation.z);
        }
        if (horizontal < -0.1f)
        {
            Vector3 eulerRotation = transform.rotation.eulerAngles;
            transform.rotation = Quaternion.Euler(eulerRotation.x, -180, eulerRotation.z);
        }

        /* if (Input.GetKeyDown(KeyCode.W) && jump == false)
         {
             //Player2D.velocity = Vector2.up * jumpVelocity;
             jump = true;
         }*/


    }
    public void Update()
    {
        vertical = Input.GetAxisRaw("Vertical");

        if (Input.GetKey(KeyCode.W) && jump == false)
        {
            Player2D.AddForce(new Vector2(0f, vertical * height), ForceMode2D.Impulse);
            jump = true;
            Jump.Play();
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            jump = false;
        }
        if (collision.gameObject.tag == "Coin")
        {
            Destroy(collision.gameObject);
        }
    }

}

