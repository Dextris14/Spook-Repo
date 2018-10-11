using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {
    public int Health = 100;
    public Text HealthVisual;
    public Slider HealthBar;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Health <=0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        HealthVisual.GetComponent<Text>().text = Health + "%";
        HealthBar.GetComponent<Slider>().value = Health;
	}

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Health = Health - 3;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Health = Health - 3;
        }
    }
}
