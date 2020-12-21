﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;   
    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        // offset the camera to a position with respect to the player
        transform.position = player.transform.position + offset;       
    }
}
