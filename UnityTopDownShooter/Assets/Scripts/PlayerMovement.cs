using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
    private float playerSpeed = 50;
    private float maxSpeed = 10;
    private Rigidbody2D rigid;

    private Vector3 playerCamPos;
    private Vector3 dir;

	void Start () 
    {
        rigid = GetComponent<Rigidbody2D>();
	}

	void Update () 
    {
        PlayerLookAtMouse();
	}

    void FixedUpdate()
    {
        PlayerMovementControl();
    }

    void PlayerMovementControl()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rigid.AddForce(new Vector2(-playerSpeed, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigid.AddForce(new Vector2(playerSpeed, 0));
        }
        if (Input.GetKey(KeyCode.W))
        {
            rigid.AddForce(new Vector2(0, playerSpeed));
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigid.AddForce(new Vector2(0, -playerSpeed));
        }

        if (rigid.velocity.magnitude > maxSpeed)
        {
            rigid.velocity = rigid.velocity.normalized * maxSpeed;
        }
    }

    void PlayerLookAtMouse()
    {
        playerCamPos = Camera.main.WorldToScreenPoint(transform.position);
        dir = Input.mousePosition - playerCamPos;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg));
    }
}
