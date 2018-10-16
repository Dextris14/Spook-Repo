﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransition : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Transition1")
        {
            SceneManager.LoadScene("Level2");
        }
        if (collision.gameObject.name == "Transition2")
        {
            SceneManager.LoadScene("Level3");
        }
        if (collision.gameObject.name == "Transition3")
        {
            SceneManager.LoadScene("Level4");
        }
        if (collision.gameObject.name == "Transition4")
        {
            SceneManager.LoadScene("Level5");
        }
        if (collision.gameObject.name == "Transition5")
        {
            SceneManager.LoadScene("WinScene");
        }
    }
}
