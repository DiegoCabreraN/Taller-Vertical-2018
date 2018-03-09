using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Begin : MonoBehaviour {
    public GameObject Menu;
    public GameObject Names;

    public void botonExit() {
        Application.Quit();
    }

    public void displayNames() {
        Menu.SetActive(false);
        Names.SetActive(true);
    }

    public void returnMenu() {
        Names.SetActive(false);
        Menu.SetActive(true);
    }
}
