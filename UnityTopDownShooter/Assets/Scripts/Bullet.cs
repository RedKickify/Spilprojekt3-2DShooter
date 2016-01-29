using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour 
{
    public float speed;

	void Start () 
    {
	
	}
	
	void Update () 
    {
        MovementControl();
	}

    void MovementControl()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
    }
}
