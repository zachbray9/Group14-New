using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingHeadController : MonoBehaviour
{
    private Rigidbody rigidbody;
    private Vector3 movement;
 
    public Transform Player;
    int MoveSpeed = 4;
    int MaxDist = 10;
    int MinDist = 0;
    int numTimesHit;
 
 
    void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        Player = GameObject.FindWithTag("Player").transform;
        numTimesHit = 0;
    }
 
     void Update()
     {
         movement = new Vector3()
         transform.LookAt(Player);
 
         if (Vector3.Distance(transform.position, Player.position) >= MinDist)
         {
 
             transform.position += transform.forward * MoveSpeed * Time.deltaTime;
 
 
 
             if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
             {
                 //Here Call any function U want Like Shoot at here or something
             }
 
         }
     }

     void FixedUpdate()
     {
         rigidbody.velocity = movement;
     }

     void OnCollisionEnter(Collision collided)
     {
        if(collided.gameObject.tag == "Projectile")
        {
            numTimesHit += 1;

            if(numTimesHit >= 1)
            {
                Destroy(this.gameObject);
            }
        }
     }

}
