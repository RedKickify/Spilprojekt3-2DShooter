using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour 
{
    private GameObject player;

	void Start () 
    {
        player = GameObject.Find("EmptyPlayer");
	}

	void Update () 
    {
        FollowPlayer();
	}

    void FollowPlayer()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10);
    }
}