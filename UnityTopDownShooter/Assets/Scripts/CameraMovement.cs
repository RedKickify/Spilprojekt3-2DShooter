﻿using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour 
{
    private GameObject player;

	void Start () 
    {
        player = GameObject.Find("EmtyPlayer");
	}

	void Update () 
    {
        FollowPlayer();
	}

    void FollowPlayer()
    { 
       
    }
}