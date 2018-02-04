using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;


public class CombatMusicControl : MonoBehaviour {

    public AudioMixerSnapshot Opening;
    public AudioMixerSnapshot Battle;
    /*public AudioClip[] stings;
    public AudioSource stingSource;
    */
   public float bpm = 128;
    private float m_TransitionIn;
    private float m_TransitionOut;
    private float m_QuarterNote;

	// Use this for initialization
	void Start () {
        m_QuarterNote = 60 / bpm;
        m_TransitionIn = m_QuarterNote;
        m_TransitionOut = m_QuarterNote * 32;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
