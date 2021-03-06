﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotonNetworkManager : MonoBehaviour
{
    public byte maxplayers = 2;
    [SerializeField] private Text connectText;
    [SerializeField] private GameObject player;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private GameObject lobbyMenu;

    // Use this for initialization
    public void OnClick_ConnectToServer () {
        // Connect to Photon server
        PhotonNetwork.ConnectUsingSettings("0.1");
	}

    public virtual void OnJoinedLobby()
    {
        Debug.Log("We should now be in the lobby");

        RoomOptions roomOptions = new RoomOptions();
        roomOptions.MaxPlayers = maxplayers;

        // Join a room if it exists, or create one
        PhotonNetwork.JoinOrCreateRoom("NewLobby", roomOptions, null);
    }

    public virtual void OnJoinedRoom()
    {
        // Spawn in the player
        PhotonNetwork.Instantiate(player.name, spawnPoint.position + new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), 0), spawnPoint.rotation, 0);
        // Deactivate the lobby camera
        lobbyMenu.SetActive(false);
    }
	
	// Update is called once per frame
	private void Update () {
        // NOTE: FOR TESTING ONLY
        connectText.text = PhotonNetwork.connectionStateDetailed.ToString() + ". . .";
	}
}
