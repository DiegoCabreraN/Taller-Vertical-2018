using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGame : MonoBehaviour {
    private GameObject Menu;
        
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Menu.SetActive(false);
        }
    }
}
