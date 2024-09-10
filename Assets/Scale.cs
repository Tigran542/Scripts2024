using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scale : MonoBehaviour
{
    private int count;
    private Text txt;

    void Start()
    {
        txt = GameObject.Find("Text").GetComponent <Text>();

    }



    void OnMouseDown()
    {
        transform.localScale = new Vector3(transform.localScale.x / 2f, transform.localScale.y / 2f, transform.localScale.z / 2f);
    }

    void OnTriggerEnter(Collider other)
    {
        count++;
        txt.text = other.gameObject.name + "" + count.ToString();
    }
}
