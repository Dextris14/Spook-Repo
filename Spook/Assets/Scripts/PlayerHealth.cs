using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {
    public int Health = 100;
    public Text HealthVisual;
    public Slider HealthBar;
    public Text VenomIndicator;
    public int Level = 0;
    public float VenomTime;
    public float VenomDelay;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        HealthVisual.GetComponent<Text>().text = Health + "%";
        HealthBar.GetComponent<Slider>().value = Health;
        if (Health <=0)
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
        VenomTime -= Time.deltaTime;
        VenomDelay += Time.deltaTime;
        if(VenomDelay >= 1.1)
        {
            VenomDelay = 0;
        }
        if(VenomTime > 0)
        {
            VenomIndicator.GetComponent<Text>().enabled = true;
        }
        else
        {
            VenomIndicator.GetComponent<Text>().enabled = false;
        }
        if(VenomTime > 0 && VenomDelay >= 1)
        {
            Health -= 1;
        }
	}

    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Health = Health - collision.gameObject.GetComponent<EnemyMovement>().Damage;
            if(collision.gameObject.GetComponent<EnemyMovement>().Type == 5)
            {
                VenomTime = 5;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "HealthPack")
        {
            Health += 25;
            Destroy(collision.gameObject);
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
