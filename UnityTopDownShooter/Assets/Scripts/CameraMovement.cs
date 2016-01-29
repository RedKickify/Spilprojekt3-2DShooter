using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour 
{
    public GameObject player;

	void Start () 
    {

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