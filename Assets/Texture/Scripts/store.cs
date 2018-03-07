using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class store : MonoBehaviour {
    //Este Script Tiene Su Uso En La Animación De Las Puertas Automáticas
    //public AudioSource au;
    [Tooltip("No Toques estas medidas")]
    public GameObject[] go = new GameObject[2];
    [Tooltip("No Toques estas medidas tampoco")]
    public float[] posicionesdepuerta = new float[4];
    public float speed;
    [HideInInspector]
    public bool move, EventoSalida, active = false;

	void Start () {
        //au.Play();
        AnimacionPuertas();
	}
	
	void Update () {
        AnimacionPuertas();
	}

    public void AnimacionPuertas() {
        if (move)
        {
            if (go[0].transform.localPosition.x >= posicionesdepuerta[0])
            {
                go[0].transform.Translate(new Vector3(posicionesdepuerta[0], 0, 0) * Time.deltaTime * speed);
            }
            if (go[1].transform.localPosition.x <= posicionesdepuerta[2])
            {
                go[1].transform.Translate(new Vector3(posicionesdepuerta[2], 0, 0) * Time.deltaTime * speed);
            }
        }
        else
        {
            if (go[0].transform.localPosition.x <= posicionesdepuerta[1])
            {
                go[0].transform.Translate(new Vector3(posicionesdepuerta[1], 0, 0) * Time.deltaTime * -speed);
            }
            if (go[1].transform.localPosition.x >= posicionesdepuerta[3])
            {
                go[1].transform.Translate(new Vector3(posicionesdepuerta[3], 0, 0) * Time.deltaTime * -speed);
            }
        }
    }

    void OnTriggerEnter(Collider coll) {
        if (active)
        {
            if (coll.CompareTag("Player"))
            {
                move = true;
                EventoSalida = true;
            }
        }
    }

    void OnTriggerExit(Collider coll) {
        if (coll.CompareTag("Player")) {
            move = false;
            active = true;
            EventoSalida = false;
        }
    }
}
