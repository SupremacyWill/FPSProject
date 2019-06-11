using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clases : MonoBehaviour
{
    
    void Start()
    {
     Debug.Log("Tu Madre");
        GameObject bolota = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        bolota.GetComponent<Renderer>().material.color = Color.black;
        bolota.transform.(5,5,5);
    }
}
