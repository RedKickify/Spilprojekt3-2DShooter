﻿using UnityEngine;
using System.Collections;

public class PlayerRotation : MonoBehaviour 
{
    private Vector3 playerCamPos;
    private Vector3 dir;

    void Start()
    {
    }

    void Update()
    {
        PlayerLookAtMouse();
    }

    void PlayerLookAtMouse()
    {
        playerCamPos = Camera.main.WorldToScreenPoint(transform.position);
        dir = Input.mousePosition - playerCamPos;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg));
    }
}
