using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAnimation : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Animator>().SetBool("Animate", true);
	}
	
	// Update is called once per frame
	void Update () {
        if (GetComponent<Rigidbody2D>().position.x < 0 && GetComponent<Rigidbody2D>().position.y < .2)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(1, 0);
        }
        if (GetComponent<Rigidbody2D>().position.x > 12)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1);
        }
        if (GetComponent<Rigidbody2D>().position.y > 8)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-10, 0);
        }
        if (GetComponent<Rigidbody2D>().position.x < 0 && GetComponent<Rigidbody2D>().position.y > 8)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -10);
        }
    }
}
