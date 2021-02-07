using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingHeadControllerFixed : MonoBehaviour
{
    private StatManager statManager;
    private Rigidbody rigidbody;
    private Vector3 movement;
 
    public Transform Player;
    int MoveSpeed = 4;
    int numTimesHit;
 
 
    void Awake()
    {
        statManager = GameObject.FindObjectOfType<StatManager>();
        rigidbody = GetComponent<Rigidbody>();
        Player = GameObject.FindWithTag("Player").transform;
        numTimesHit = 0;
    }
 
     void Update()
     {
         movement = new Vector3(rigidbody.transform.forward.x * MoveSpeed, 0, rigidbody.transform.forward.z * MoveSpeed);
         transform.LookAt(Player.transform);
 
        
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

        if(collided.gameObject.tag == "Player")
        {
            statManager.loseHealth(100);
            Destroy(this.gameObject);
        }
     }

}
