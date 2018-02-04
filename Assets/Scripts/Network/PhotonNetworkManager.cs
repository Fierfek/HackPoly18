using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotonNetworkManager : Photon.MonoBehaviour
{
    [SerializeField] private Text connectText;
    [SerializeField] private GameObject player;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private GameObject lobbyCamera;

    // Use this for initialization
    private void Start () {
        // Connect to Photon server
        PhotonNetwork.ConnectUsingSettings("0.1");
	}

    public virtual void OnJoinedLobby()
    {
        Debug.Log("We should now be in the lobby");

        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = 2;

        // Join a room if it exists, or create one
        PhotonNetwork.JoinOrCreateRoom("NewLobby", roomOptions, null);
    }

    public virtual void OnJoinedRoom()
    {
        // Spawn in the player
        PhotonNetwork.Instantiate(player.name, spawnPoint.position, spawnPoint.rotation, 0);
        // Deactivate the lobby camera
        lobbyCamera.SetActive(false);
    }
	
	// Update is called once per frame
	private void Update () {
        // NOTE: FOR TESTING ONLY
        connectText.text = PhotonNetwork.connectionStateDetailed.ToString();
	}
}
