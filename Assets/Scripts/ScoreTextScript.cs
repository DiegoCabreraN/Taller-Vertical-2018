using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;


public class ScoreTextScript : MonoBehaviour {

	public Text ganastePerdiste;
	public static int result = 2;
	Texture2D winTexture;
	Texture2D loseTexture;

	// Use this for initialization
	void Start () {
		winTexture = Resources.Load ("Images/Winner") as Texture2D;
		loseTexture = Resources.Load ("Images/GAME OVER") as Texture2D;
		GameObject rawImage = GameObject.Find ("WinLoseImage");
		SetGanastePerdiste (rawImage);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void SetGanastePerdiste(GameObject rawImage)
	{
		
		
		if (result == 0) {
			ganastePerdiste.text = "¡Ganaste!";
			rawImage.GetComponent<RawImage> ().texture = winTexture;


		} else if (result == 1) {

			ganastePerdiste.text = "¡Perdiste!";
			rawImage.GetComponent<RawImage> ().texture = loseTexture;

		} else if (result == 2) {

			ganastePerdiste.fontSize = 20;
			ganastePerdiste.text = "¡Se acabó el tiempo!";
			rawImage.GetComponent<RawImage> ().texture = loseTexture;

		}

	}
}
