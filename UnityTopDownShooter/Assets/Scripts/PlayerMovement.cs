using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
    private float playerSpeed = 50;
    private float maxSpeed = 10;
    private Rigidbody2D rigid;

	void Start () 
    {
        rigid = GetComponent<Rigidbody2D>();
	}

	void Update () 
    {
	
	}

    void FixedUpdate()
    {
        PlayerMovementControl();
    }

    void PlayerMovementControl()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rigid.AddRelativeForce(new Vector2(-playerSpeed, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigid.AddRelativeForce(new Vector2(playerSpeed, 0));
        }
        if (Input.GetKey(KeyCode.W))
        {
            rigid.AddRelativeForce(new Vector2(0, playerSpeed));
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigid.AddRelativeForce(new Vector2(0, -playerSpeed));
        }

        if (rigid.velocity.magnitude > maxSpeed)
        {
            rigid.velocity = rigid.velocity.normalized * maxSpeed;
        }
    }
}
