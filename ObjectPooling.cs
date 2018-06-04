using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour {

    public GameObject pooling;
    public int poolNum;
    List<GameObject> poolingObject;
	// Use this for initialization
	void Start () {
        poolingObject = new List<GameObject>();
        for (int i = 0; i < poolNum; i++)
        {
            GameObject Obj = (GameObject) Instantiate(pooling);
            Obj.SetActive(false);
            poolingObject.Add(Obj);
        }
		
	}
	
	public GameObject GetPooledObject()
    {
        for(int i = 0; i < poolingObject.Count; i++)
        {
            if(!poolingObject[i].activeInHierarchy)
            { return poolingObject[i]; }
        }
        GameObject Obj = (GameObject)Instantiate(pooling);
        Obj.SetActive(false);
        poolingObject.Add(Obj);
        return Obj;
    }
}
