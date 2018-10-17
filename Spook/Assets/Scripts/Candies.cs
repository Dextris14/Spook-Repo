using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Candies : MonoBehaviour {
    public int CandyCount = 0;
    public Text CandyCounter;
    public GameObject Pumpkin;
    public GameObject Transition;
    public int Level;
	// Use this for initialization
	void Start () {
        Pumpkin.SetActive(false);
        Transition.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if(Level == 1)
        {
            CandyCounter.text = CandyCount + "/10";
        }
        if (Level == 2)
        {
            CandyCounter.text = CandyCount + "/10";
        }
        if (Level == 3)
        {
            CandyCounter.text = CandyCount + "/10";
        }
        if (Level == 4)
        {
            CandyCounter.text = CandyCount + "/10";
        }
        if (Level == 5)
        {
            CandyCounter.text = CandyCount + "/10";
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Candy")
        {
            CandyCount++;
            Destroy(collision.gameObject);
            if(Level == 1 && CandyCount >= 10)
            {
                Pumpkin.SetActive(true);
            }
            if (Level == 2 && CandyCount >= 10)
            {
                Pumpkin.SetActive(true);
            }
            if (Level == 3 && CandyCount >= 10)
            {
                Pumpkin.SetActive(true);
            }
            if (Level == 4 && CandyCount >= 10)
            {
                Pumpkin.SetActive(true);
            }
            if (Level == 5 && CandyCount >= 10)
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
