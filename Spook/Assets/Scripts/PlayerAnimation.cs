using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    float x;
    float y;
    bool LastUp;
    bool LastDown = true;
    bool LastRight;
    bool LastLeft;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0)
        {
            x = Input.GetAxis("Horizontal");
            GetComponent<Animator>().SetFloat("X", x);
            GetComponent<Animator>().SetFloat("Y", 0);
            GetComponent<Animator>().SetBool("IdleUp", false);
            GetComponent<Animator>().SetBool("IdleLeft", false);
            GetComponent<Animator>().SetBool("IdleDown", false);
            GetComponent<Animator>().SetBool("IdleRight", false);
            if (x > 0)
            {
                LastUp = false;
                LastDown = false;
                LastRight = true;
                LastLeft = false;
            }
            if (x < 0)
            {
                LastUp = false;
                LastDown = false;
                LastRight = false;
                LastLeft = true;
            }
        }
        else if (Input.GetAxis("Vertical") != 0)
        {
            y = Input.GetAxis("Vertical");
            GetComponent<Animator>().SetFloat("Y", y);
            GetComponent<Animator>().SetFloat("X", 0);
            GetComponent<Animator>().SetBool("IdleUp", false);
            GetComponent<Animator>().SetBool("IdleLeft", false);
            GetComponent<Animator>().SetBool("IdleDown", false);
            GetComponent<Animator>().SetBool("IdleRight", false);
            if (y > 0)
            {
                LastUp = true;
                LastDown = false;
                LastRight = false;
                LastLeft = false;
            }
            if (y < 0)
            {
                LastUp = false;
                LastDown = true;
                LastRight = false;
                LastLeft = false;
            }
        }
        else
        {
            if (LastUp == true)
            {
                GetComponent<Animator>().SetBool("IdleUp", true);
                GetComponent<Animator>().SetBool("IdleLeft", false);
                GetComponent<Animator>().SetBool("IdleDown", false);
                GetComponent<Animator>().SetBool("IdleRight", false);
                GetComponent<Animator>().SetFloat("X", 0);
                GetComponent<Animator>().SetFloat("Y", 0);
            }
            if (LastDown == true)
            {
                GetComponent<Animator>().SetBool("IdleDown", true);
                GetComponent<Animator>().SetBool("IdleUp", false);
                GetComponent<Animator>().SetBool("IdleLeft", false);
                GetComponent<Animator>().SetBool("IdleRight", false);
                GetComponent<Animator>().SetFloat("X", 0);
                GetComponent<Animator>().SetFloat("Y", 0);
            }
            if (LastRight == true)
            {
                GetComponent<Animator>().SetBool("IdleRight", true);
                GetComponent<Animator>().SetBool("IdleUp", false);
                GetComponent<Animator>().SetBool("IdleLeft", false);
                GetComponent<Animator>().SetBool("IdleDown", false);
                GetComponent<Animator>().SetFloat("X", 0);
                GetComponent<Animator>().SetFloat("Y", 0);
            }
            if (LastLeft == true)
            {
                GetComponent<Animator>().SetBool("IdleLeft", true);
                GetComponent<Animator>().SetBool("IdleUp", false);
                GetComponent<Animator>().SetBool("IdleDown", false);
                GetComponent<Animator>().SetBool("IdleRight", false);
                GetComponent<Animator>().SetFloat("X", 0);
                GetComponent<Animator>().SetFloat("Y", 0);
            }
        }
    }
}
