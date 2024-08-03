using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherScript : MonoBehaviour
{
    public GameObject obj2;
    public float range = 5f, moveSpeed = 3f, turnSpeed = 40f;

    private void Update()
    {
        //float h = Input.GetAxis("Horizontal");
       //float xPos = h * range;

        //obj2.transform.position = new Vector3(xPos, 0, 0);


        if (Input.GetKey(KeyCode.UpArrow))
            obj2.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            obj2.transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
            obj2.transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            obj2.transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
    }


}
