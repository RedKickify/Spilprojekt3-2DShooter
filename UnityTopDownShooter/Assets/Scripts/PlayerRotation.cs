using UnityEngine;
using System.Collections;

public class PlayerRotation : MonoBehaviour 
{
    private Vector3 playerCamPos;
    private Vector3 dir;

    private Rigidbody2D rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
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
