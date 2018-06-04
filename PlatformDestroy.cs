using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroy : MonoBehaviour {

    public GameObject platformDestroyer; 
	// Use this for initialization
	void Start () {
        platformDestroyer = GameObject.Find("PlatformDestroyPoint");
	}
	
	// Update is called once per frame
	void Update () {
        //if (transform.position.x < platformDestroyer.transform.position.x)
        //{
        //    gameObject.SetActive(false);
        //}
	}
}
