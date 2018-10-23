using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float Speed = 10f;
	// Use this for initialization
	void Start () {
        Speed = 10;
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 Direction = new Vector2(x, y);
        GetComponent<Rigidbody2D>().velocity = Direction * Speed;
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Web")
        {
            Speed = 4;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Speed = 10;
    }
}
