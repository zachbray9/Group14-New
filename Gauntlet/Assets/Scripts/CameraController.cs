using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    Transform player;
    private CinemachineVirtualCamera vcam;

    void Start()
    {
        vcam = GetComponent<CinemachineVirtualCamera>();
        
    }
    
    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindWithTag("Player").transform;
        vcam.Follow = player;
        vcam.LookAt = player;
        
    }
}
