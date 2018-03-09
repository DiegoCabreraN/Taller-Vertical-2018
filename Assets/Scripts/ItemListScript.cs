using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemListScript : MonoBehaviour {

	public GameObject itemList;
	// Use this for initialization
	void Start () {
		GameObject instance = Instantiate(Resources.Load("Button", typeof(GameObject))) as GameObject;	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
