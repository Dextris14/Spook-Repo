using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayThisSound : MonoBehaviour {

    public AudioClip soundToPlay;
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.U))
        {
            Camera.main.GetComponent<AudioSource>().PlayOneShot(soundToPlay);
        }
		
	}
}
