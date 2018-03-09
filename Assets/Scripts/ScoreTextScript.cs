using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class ScoreTextScript : MonoBehaviour {

	public Text ganastePerdiste;
	public static int result = 2;
	//private RawImage imageResult;
	//public Texture winTexture;
	//public Texture loseTexture;

	// Use this for initialization
	void Start () {
		
		//imageResult = gameObject.GetComponent<RawImage>();
		//SetGanastePerdiste(imageResult);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void SetGanastePerdiste(RawImage imagenResultado)
	{
		
		
		if (result == 0) {
			ganastePerdiste.text = "¡Ganaste!";
			//imagenResultado.texture = winTexture;

		} else if (result == 1) {

			ganastePerdiste.text = "¡Perdiste!";
			//imagenResultado.texture = loseTexture;

		} else if (result == 2) {

			ganastePerdiste.fontSize = 20;
			ganastePerdiste.text = "¡Se acabó el tiempo!";
			//imagenResultado.texture = loseTexture;
		}

	}
	void displayItemList(GameObject listOfItems){

	}
}
