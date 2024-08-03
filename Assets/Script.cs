using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Script : MonoBehaviour
{
    public GameObject obj;
    private Light myLight;

    private int NumEnemies = 10;

    private void Start()
    {
        myLight = GetComponent<Light>();

        for (int i = 0; i < NumEnemies; i++)
            Debug.Log("Nike Pro " + i + " enemies");
    }

    private void Update()
    {
        if (Input.GetKeyUp (KeyCode.Space))
        {
            myLight.enabled = !myLight.enabled;
        }

        if (Input.GetKeyUp(KeyCode.V))
        {
            obj.SetActive(false);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            Destroy (obj);
        }

        if (Input.GetKeyUp(KeyCode.R))
            obj.GetComponent<Renderer>().material.color = Color.red;
        else if (Input.GetKeyUp(KeyCode.G))
            obj.GetComponent<Renderer>().material.color = Color.green;
        else if (Input.GetKeyUp(KeyCode.B))
            obj.GetComponent<Renderer>().material.color = Color.blue;

       
    }
}
