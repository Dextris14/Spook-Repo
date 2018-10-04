using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    public Vector3 Relation = new Vector3();
    public float moveSpeed = 1f;
    public int Type;
	// Use this for initialization
	void Start () {
        if(Type == 1)
        {
            moveSpeed = 4;
        }
        if (Type == 2)
        {
            moveSpeed = 5;
        }
        if (Type == 3)
        {
            moveSpeed = 2;
        }
    }
	
	// Update is called once per frame
	void Update () {
        if(Type == 1)
        {
            Vector3 PlayerPosition = new Vector3(GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>().position.x, GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>().position.y, 0);
            Vector3 Relation = PlayerPosition - transform.position;
            GetComponent<Rigidbody2D>().velocity = Relation.normalized * moveSpeed;
        }
        if (Type == 2)
        {
            Vector3 PlayerPosition = new Vector3(GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>().position.x, GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>().position.y, 0);
            Vector3 Relation = PlayerPosition.normalized - transform.position.normalized;
            GetComponent<Rigidbody2D>().velocity = Relation * moveSpeed;
        }
        if (Type == 3)
        {
            Vector3 PlayerPosition = new Vector3(GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>().position.x, GameObject.FindWithTag("Player").GetComponent<Rigidbody2D>().position.y, 0);
            Vector3 Relation = PlayerPosition - transform.position.normalized;
            GetComponent<Rigidbody2D>().velocity = Relation * moveSpeed;
        }
    }
}
