using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerFixed : MonoBehaviour
{
    private StatManager statManager;

    private Rigidbody rigidbody;
    private Vector3 inputVector;

    float moveHorizontal;
    float moveVertical;
    public float speed = 10f;

    public static int KeyAmount = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        statManager = GameObject.FindObjectOfType<StatManager>();
        rigidbody = GetComponent<Rigidbody>();
        KeyAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Movement
        inputVector = new Vector3(Input.GetAxis("Horizontal") * speed, rigidbody.velocity.y, Input.GetAxis("Vertical") * speed);
        transform.LookAt(transform.position + new Vector3(inputVector.x, 0, inputVector.z));
        //
    }

    private void FixedUpdate()
    {
        rigidbody.velocity = inputVector;
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag == "Key")
        {
            KeyAmount = KeyAmount + 1;
            statManager.getPoints(100);
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
            statManager.getPoints(100);
            Destroy(other.gameObject);
        }
    }


}
