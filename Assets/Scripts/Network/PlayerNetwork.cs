using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNetwork : MonoBehaviour
{
    [SerializeField] private GameObject playerCamera;
    [SerializeField] private MonoBehaviour[] playerControlScripts;

    private PhotonView photonView;


	// Use this for initialization
	private void Start ()
    {
        photonView = GetComponent<PhotonView>();

        InitializePlayer();
	}

    private void InitializePlayer()
    {
        if (photonView.isMine)
        {
            // Do stuff
        }
        // Handle functionality for non local character
        else
        {
            // Disable it's camera
            playerCamera.SetActive(false);

            // Disable it's control scripts
            foreach(MonoBehaviour m in playerControlScripts)
            {
                m.enabled = false;
            }
        }
    }
}
