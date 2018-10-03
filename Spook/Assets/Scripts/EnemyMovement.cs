using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {
    public GameObject Player;
    public float chaseSpeed = 5f;
    public float chaseTriggerDistance = 7f;
    Vector3 startPosition;
    bool home = true;
    public Vector3 paceDirection = new Vector3(0, 0, 0);
    public float paceDistance = 3f;
    public float paceSpeed = 2f;
	// Use this for initialization
	void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
        startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 playerPosition = Player.transform.position;
        Vector3 chaseDirection = playerPosition - transform.position;
        if(chaseDirection.magnitude < chaseTriggerDistance)
        {
            home = false;
            chaseDirection.Normalize();
            GetComponent<Rigidbody2D>().velocity = chaseDirection * chaseSpeed;
        }
        else if(home == false)
        {
            Vector3 homeDirection = startPosition - transform.position;
            if(homeDirection.magnitude < .1f)
            {
                home = true;
                transform.position = startPosition;
                GetComponent<Rigidbody2D>().velocity = new Vector3(0, 0, 0);
            }
        }
	}
}
