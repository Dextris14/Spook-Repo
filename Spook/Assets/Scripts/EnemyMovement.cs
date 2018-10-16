using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    public Vector2 Relation = new Vector2();
    public float moveSpeed = 1f;
    public int Type;
    public GameObject Player;
    public float Timer = 0;
    public int Damage;
	// Use this for initialization
	void Start () {
        Player = GameObject.FindWithTag("Player");
        if (Type == 1)
        {
            moveSpeed = 4;
            Damage = 3;
        }
        if (Type == 2)
        {
            moveSpeed = 40;
            Damage = 3;
        }
        if (Type == 3)
        {
            moveSpeed = 25;
            Damage = 3;
        }
        if (Type == 4)
        {
            moveSpeed = 7;
            Damage = 3;
        }
        if (Type == 5)
        {
            moveSpeed = 6;
            Damage = 1;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if(Type == 1)
        {
            Vector2 Relation = Player.GetComponent<Rigidbody2D>().position - GetComponent<Rigidbody2D>().position;
            if(Relation.magnitude >15)
            {
                GetComponent<Rigidbody2D>().velocity = Relation.normalized * 40;
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = Relation.normalized * moveSpeed;
            }
        }
        if (Type == 2)
        {
            Timer += Time.deltaTime;
            if (Timer > .9)
            {
                Vector2 Relation = Player.GetComponent<Rigidbody2D>().position - GetComponent<Rigidbody2D>().position;
                GetComponent<Rigidbody2D>().velocity = Relation.normalized * moveSpeed;
                if (Timer > 1)
                {
                    Timer = 0;
                    GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                }
            }
        }
        if (Type == 3)
        {
            Timer += Time.deltaTime;
            if (Timer >= 1)
            {
                Vector2 Relation = Player.GetComponent<Rigidbody2D>().position - GetComponent<Rigidbody2D>().position;
                GetComponent<Rigidbody2D>().velocity = Relation.normalized * moveSpeed;
                Timer = 0;
                GetComponent<Rigidbody2D>().drag = 0;
            }
            if (Timer >= 0.3)
            {
                GetComponent<Rigidbody2D>().drag = 5;
            }
        }
        if (Type == 4)
        {
            Vector2 Relation = (Player.GetComponent<Rigidbody2D>().position + Player.GetComponent<Rigidbody2D>().velocity) - GetComponent<Rigidbody2D>().position;
            GetComponent<Rigidbody2D>().velocity = Relation.normalized * moveSpeed;
        }
        if (Type == 5)
        {
            Vector2 Relation = Player.GetComponent<Rigidbody2D>().position - GetComponent<Rigidbody2D>().position;
            if (Relation.magnitude > 15)
            {
                GetComponent<Rigidbody2D>().velocity = Relation.normalized * 40;
                
            }
            else if(Player.GetComponent<PlayerMovement>().Speed == 4)
            {
                GetComponent<Rigidbody2D>().velocity = Relation.normalized * 10;
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = Relation.normalized * moveSpeed;
            }
        }
    }
}
