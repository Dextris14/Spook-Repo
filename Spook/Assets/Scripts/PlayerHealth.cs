using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {
    public int Health = 100;
    public Text HealthVisual;
    public Slider HealthBar;
    public int Level = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Health <=0)
        {
            if(Level == 1)
            {
                SceneManager.LoadScene("DeathScene1");
            }
            if (Level == 2)
            {
                SceneManager.LoadScene("DeathScene2");
            }
            if (Level == 3)
            {
                SceneManager.LoadScene("DeathScene3");
            }
            if (Level == 4)
            {
                SceneManager.LoadScene("DeathScene4");
            }
            if (Level == 5)
            {
                SceneManager.LoadScene("DeathScene5");
            }
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
