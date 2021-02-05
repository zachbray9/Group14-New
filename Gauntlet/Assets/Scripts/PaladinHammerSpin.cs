using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaladinHammerSpin : MonoBehaviour
{
    public float turnSpeed = 50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(turnSpeed, 0, 0);
    }
}
