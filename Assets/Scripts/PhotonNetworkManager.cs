using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhotonNetworkManager : Photon.MonoBehaviour
{
    [SerializeField]
    private Text connectText;

	// Use this for initialization
	void Start () {
        PhotonNetwork.ConnectUsingSettings("0.1"); // Manages version, only players with same game version can connect
	}
	
	// Update is called once per frame
	void Update () {
        // NOTE: FOR TESTING ONLY
        connectText.text = PhotonNetwork.connectionStateDetailed.ToString();
	}
}
