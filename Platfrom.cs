using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platfrom : MonoBehaviour {

    public GameObject platform;
    public Transform generationPoint;
    public float distanceBetween;

    private float platformWidth;

    public float platformMin;
    public float platformMax;

    //public GameObject[] platforms;
    private int numSelector;
    private float[] platformWidths;

    public ObjectPooling[] objPool;

    /*private float minHeight;
    public Transform maxHeightPoint;
    private float maxHeight;
    public float maxHightChange;
    private float heightChange;*/

   // public ObjectPooling obj; 

	// Use this for initialization
	void Start () {
        // platformWidth = platform.GetComponent<BoxCollider2D>().size.x;
        platformWidths = new float[objPool.Length];
        for (int i = 0; i < objPool.Length; i++)
        {
            platformWidths[i] = objPool[i].pooling.GetComponent<BoxCollider2D>().size.x; 
        }

        //minHeight = transform.position.y;
        //maxHeight = maxHeightPoint.position.y;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < generationPoint.position.x) //if we are at the end of the current last platform 
        {
            distanceBetween = Random.Range(platformMin, platformMax);
            numSelector = Random.Range(0, objPool.Length);
            //heightChange = transform.position.y + Random.Range(maxHightChange, -maxHightChange);

            transform.position = new Vector3(transform.position.x + (platformWidths[numSelector]/2) + distanceBetween, transform.position.y, transform.position.z);

            //Instantiate(platforms[numSelector], transform.position, transform.rotation);

            GameObject newPlatform = objPool[numSelector].GetPooledObject();

            newPlatform.transform.position = transform.position;
            newPlatform.transform.rotation = transform.rotation;
            newPlatform.SetActive(true);

            transform.position = new Vector3(transform.position.x + (platformWidths[numSelector] / 2), transform.position.y, transform.position.z);
        }
	}
}
