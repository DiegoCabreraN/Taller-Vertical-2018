using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickonposition : MonoBehaviour {
    public GameObject VR, pos;
    public float speed;
    public Vector3 position;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (VR.transform.position != pos.transform.position)
        {
            VR.transform.position = position;
        }
        else {
            VR.transform.position = pos.transform.position;
        }
        
	}
    public void move() {
        float x = pos.transform.position.x;
        float z = pos.transform.position.z;
        position = new Vector3(x, -0.6f, z);

    }
}
