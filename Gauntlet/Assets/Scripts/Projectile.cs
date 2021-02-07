using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public GameObject projectileEmitter;
    public GameObject prefabToSpawn;
    public float projectileSpeed;

    AudioSource audioSource;
    public  AudioClip ProjectileSound;

    // Start is called before the first frame update
    void Start()
    {
       audioSource = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown("space"))
       {
           GameObject tempProjectileHandler;
           tempProjectileHandler = Instantiate(prefabToSpawn, projectileEmitter.transform.position, projectileEmitter.transform.rotation) as GameObject;

            tempProjectileHandler.transform.Rotate(Vector3.left * 180);                                                                 //May have to change value of 180 to make projectile face correct direction

            Rigidbody tempRigidbody;
            tempRigidbody = tempProjectileHandler.GetComponent<Rigidbody>();

            tempRigidbody.AddForce(transform.forward * projectileSpeed);

            Destroy(tempProjectileHandler, 3f);
            
            audioSource.PlayOneShot(ProjectileSound);
       } 
    }

    
}

    
