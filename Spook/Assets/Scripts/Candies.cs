using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Candies : MonoBehaviour {
    public int CandyCount = 0;
    public Text CandyCounter;
    public GameObject Pumpkin;
    public GameObject Transition;
	// Use this for initialization
	void Start () {
        Pumpkin.SetActive(false);
        Transition.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        CandyCounter.text = CandyCount + "/10";
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Candy")
        {
            CandyCount++;
            Destroy(collision.gameObject);
            if (CandyCount >= 10)
            {
                Pumpkin.SetActive(true);
            }
        }

        if(collision.gameObject.tag == "Pumpkin")
        {
            Transition.SetActive(true);
            collision.gameObject.SetActive(false);
        }
    }
}
