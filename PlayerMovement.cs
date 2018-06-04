using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    Animator player;
	// Use this for initialization
	void Start () {
        player = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        //running 
		if(Input.GetKeyDown(KeyCode.D)||Input.GetKeyDown(KeyCode.RightArrow))
        {
            player.SetInteger("State",1);
        }
        if (Input.GetKeyUp(KeyCode.D)||Input.GetKeyUp(KeyCode.RightArrow))
        {
            player.SetInteger("State", 0);
        }
        //jumping/falling?
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space))
        {
            player.SetInteger("State", 2);
        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.Space))
        {
            player.SetInteger("State", 0);
        }
    }
}
