using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour {

	public GameObject hand;
	public bool isTouched = false;

	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.name == "hand" && isTouched == false)
		{
			transform.localScale -= new Vector3(0.1F, 0, 0); 			
			Debug.Log ("Has chocado el botón");
			isTouched = true;
		}
	}

	void OnCollisionExit(Collision collision)
	{
		if(collision.gameObject.name == "hand" && isTouched == true)
		{
			transform.localScale += new Vector3(0.1F, 0, 0); 
			Debug.Log ("Has dejado de chocar el botón");
			isTouched = false;
		}
	}
		
}
