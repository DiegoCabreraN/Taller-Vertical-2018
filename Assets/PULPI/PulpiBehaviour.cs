using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulpiBehaviour : MonoBehaviour {

	private Animator anim;
	public Animator bocas; 
	// Use this for initialization
	void Start () {
		
		this.anim = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

		//anim.SetBool("Happy", true);
	}
}
