using UnityEngine;
using System.Collections;

public class SecWeapon : Photon.PunBehaviour 
{
    public float Damage;
    public float BulletSpeed;
    public bool active;

    public GameObject SecBullet;
    public Transform BulletPointStart;

	void Start () 
    {
	
	}
	
	void Update () 
    {
        ShootingControl();
	}

    void ShootingControl()
    {
        if (active)
        { 
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                SecBullet = PhotonNetwork.Instantiate("SecBullet", BulletPointStart.position, transform.rotation, 0);
                //Instantiate(SecBullet, BulletPointStart.position, transform.rotation);
            }
        }
    }
}
