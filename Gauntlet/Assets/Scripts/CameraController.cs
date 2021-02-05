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
        player = GameObject.FindWithTag("Player").transform;
    }
    
    // Update is called once per frame
    void Update()
    {
        vcam.Follow = player;
        vcam.LookAt = player;
        
    }
}
