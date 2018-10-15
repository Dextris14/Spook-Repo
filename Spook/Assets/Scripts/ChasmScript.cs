using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasmScript : MonoBehaviour {
    public GameObject Player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Transform>().position = -Player.transform.position / 10;
	}
}
