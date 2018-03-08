using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class itemlist : MonoBehaviour
{

    public Text[] textirri;
    public string[] elementos;
    // Use this for initialization
    void Start()
    {
        for (int i = textirri.Length-1; i >= 0; i--)
        {
            textirri[i].text = elementos[i];
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
