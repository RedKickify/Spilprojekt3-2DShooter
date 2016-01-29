using UnityEngine;
using System.Collections;

public class NetworkManager : Photon.PunBehaviour 
{

	void Start () 
    {
        PhotonNetwork.ConnectUsingSettings("2DCS V0.1");
	}

    void OnConnectedToMaster()
    {
        RoomOptions roomOptions = new RoomOptions() { isVisible = false, maxPlayers = 10 };
        PhotonNetwork.JoinOrCreateRoom("Play2D:CS", roomOptions, TypedLobby.Default);
    }

    public override void OnJoinedRoom()
    {
        GameObject player = PhotonNetwork.Instantiate("EmptyPlayer", new Vector3(0, 0), Quaternion.identity, 0);
    }

    void OnGUI()
    {
        GUILayout.Label(PhotonNetwork.connectionStateDetailed.ToString());
    }
}
