using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MasterObject : MonoBehaviour {
    [Header("Tiempo")]
    [Tooltip("Tiempo de juego en minutos")]
    public float Minutos;
    [Tooltip("Atributo Texto del contador")]
    public Text Contador;
    [HideInInspector]
    public float Segundos = 60;
    [Space(10)]
    [Header("Dificultad")]
    public int Nivel;
    public GameObject Entrada;
    //[HideInInspector]
    public bool EventoSalida;
    [Space (10)]
    [Header("Eventos")]
    public bool[] eventos;
    [Space(10)]
    [Header("Acciones")]
    public Acciones[] Accions;
    [HideInInspector]
    public int score, limitscore;
    [Header("Panalla Final")]
    public GameObject PantallaFinal;


    /////////////////////////// Metodo Update //////////////////////////
    void Update() {

        //////////////////// Timer /////////////////////
        Segundos -= Time.deltaTime;
        if (Minutos > 0)
        {
            if (Segundos > 0)
            {
                Contador.text = Minutos + ":" + (Mathf.Round(Segundos));
            }
            else
            {
                Segundos += 60;
                Minutos -= 1;
            }
        }
        else {
            if (Segundos > 0)
            {
                Contador.text = Minutos + ":" + (Mathf.Round(Segundos));
            }
            else
            {
                Contador.text = "GAME OVER";
            }

        }
        ////////////////////////////////////////////////


        /////////////////// Encender ///////////////////
        if (eventos[0]) {
            Accions[0].encender();
        }
        ////////////////////////////////////////////////


        //////////////////// End ///////////////////////
        if (score >= limitscore) {
            //PantallaFinal.SetActive(true);
        }
        ////////////////////////////////////////////////

        this.EventoSalida = Entrada.GetComponent<store>().EventoSalida;
    }
    ////////////////////////////////////////////////////////////////////



    /////////////////////////// Metodo Reset ///////////////////////////
    public void Reset() {
        SceneManager.LoadScene(0);
    }
    ////////////////////////////////////////////////////////////////////

}
