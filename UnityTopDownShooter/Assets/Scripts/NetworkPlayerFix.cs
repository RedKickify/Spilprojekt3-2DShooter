using UnityEngine;
using System.Collections;

public class NetworkPlayerFix : Photon.PunBehaviour 
{
	void Start () 
    {
        if (photonView.isMine)
        {
            GetComponent<PlayerMovement>().enabled = true;
            GetComponent<SecWeapon>().enabled = true;
        }
	}

	void Update ()
    {
	
	}
}
