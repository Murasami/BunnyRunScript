using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public PlayerController player;
    private Vector3 playerLastPosition;
    private float moveAlong; 

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();
        playerLastPosition = player.transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        moveAlong = player.transform.position.x - playerLastPosition.x;
        transform.position = new Vector3(transform.position.x + moveAlong, transform.position.y, transform.position.z);
        playerLastPosition = player.transform.position;
	}
}
