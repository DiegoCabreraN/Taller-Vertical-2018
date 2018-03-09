using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pegamento : MonoBehaviour {
    public GameObject go;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider coll)
    {
        if (coll.CompareTag("producto")){
            go.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionY;
            

        }

    }
}
