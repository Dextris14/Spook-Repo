using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Candies : MonoBehaviour {
    public int CandyCount = 0;
    public Text CandyCounter;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        CandyCounter.text = "" + CandyCount;
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Candy")
        {
            CandyCount++;
            Destroy(collision.gameObject);
        }
    }
}
