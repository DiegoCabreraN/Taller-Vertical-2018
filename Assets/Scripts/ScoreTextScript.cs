using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class ScoreTextScript : MonoBehaviour {

	public GameObject itemlist;
	public Text[] itemList;
	public Text ganastePerdiste;
	public Text winText;
	public static int result = 2;

	// Use this for initialization
	void Start () {
		SetGanastePerdisteText ();
		displayItemList (itemlist);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void SetGanastePerdisteText ()
	{
		
		if (result == 0) {
			ganastePerdiste.text = "¡Ganaste!";

		} else if (result == 1) {

			ganastePerdiste.text = "¡Perdiste!";

		} else if (result == 2) {

			ganastePerdiste.fontSize = 20;
			ganastePerdiste.text = "¡Se acabó el tiempo!";
		}

	}
	void displayItemList(GameObject listOfItems){
	
		this.itemlist = listOfItems;
		Debug.Log (itemList.ToString());
	
	}
}
