using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leader : MonoBehaviour {
    public GameObject Player;
    public GameObject Pumpkin;
    public GameObject Transition;
	// Use this for initialization
	void Start () {
        Player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = Player.GetComponent<Rigidbody2D>().velocity;
        GameObject Candy = GameObject.FindWithTag("Candy");
        if(Pumpkin.activeSelf)
        {
            GetComponent<Rigidbody2D>().position = Player.GetComponent<Rigidbody2D>().position + (Pumpkin.GetComponent<Rigidbody2D>().position - Player.GetComponent<Rigidbody2D>().position).normalized;
        }
        else if(Transition.activeSelf)
        {
            GetComponent<Rigidbody2D>().position = Player.GetComponent<Rigidbody2D>().position + (Transition.GetComponent<Rigidbody2D>().position - Player.GetComponent<Rigidbody2D>().position).normalized;
            
        }
        else
        {
            if(Player.GetComponent<Candies>().CandyCount >= 7)
            {
                GetComponent<Rigidbody2D>().position = Player.GetComponent<Rigidbody2D>().position + (Candy.GetComponent<Rigidbody2D>().position - Player.GetComponent<Rigidbody2D>().position).normalized;
                GetComponent<SpriteRenderer>().enabled = true;
            }
        }
	}
}
