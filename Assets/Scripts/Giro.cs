using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giro : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, transform.eulerAngles.y, 0);
        transform.position = new Vector3(transform.position.x, 0.5342169f, transform.position.z);
    }
}
