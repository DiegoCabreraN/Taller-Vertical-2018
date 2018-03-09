using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraController : MonoBehaviour {
    public GameObject manager;

    public void runThingy()
    {
        manager.GetComponent<Cobrador>().calculateTotalResults();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
