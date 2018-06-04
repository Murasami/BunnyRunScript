using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRunnerScript : MonoBehaviour {
    public Transform player;
	// Use this for initialization
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(player.position.x + 2, 0 , -10);
	}
}
