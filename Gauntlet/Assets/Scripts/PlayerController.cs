﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rigidbody;

    float moveHorizontal;
    float moveVertical;
    public float speed = 6f;

    public static int KeyAmount = 0;
    
    private int points;
    private int health;
    


    // Start is called before the first frame update
    void Start()
    {
        health = 2000;
        points = 0;
        KeyAmount = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Movement
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        moveVertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        if(moveHorizontal != 0 || moveVertical != 0)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movement), 0.15F);
        }

        transform.Translate(movement * speed * Time.deltaTime, Space.World);
        //

    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Key")
        {
            KeyAmount = KeyAmount + 1;
            points += 100;
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "Door")
        {
            if (0 < KeyAmount)
            {
                KeyAmount = KeyAmount - 1;
                Destroy(other.gameObject);
            }
        }

        if(other.gameObject.tag == "LootChest")
        {
            points += 100;
            Destroy(other.gameObject);
        }
    }

    
}
