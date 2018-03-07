using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggers : MonoBehaviour {
    [Header("Game Manager Script")]
    [Tooltip("Introduzca el Game Manager")]
    public GameObject Game_Manager;
    [Tooltip("Introduzca aquí el índice del evento")]
    public int n;

    void OnTriggerEnter() {
        Game_Manager.GetComponent<MasterObject>().eventos[n] = true;
    }
}
