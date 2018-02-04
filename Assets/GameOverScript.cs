using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour {


    public GameObject playAgain;
    public GameObject creditsButton;
    public GameObject exitCredits;
    public GameObject creditsPanel;
	// Use this for initialization
	void Start () {
        creditsPanel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void CreditsShow()
    {
        creditsPanel.SetActive(true);
    }

    void CreditsHide()
    {
        creditsPanel.SetActive(false);

    }
    void PlayAgain()
    {

    }
}
