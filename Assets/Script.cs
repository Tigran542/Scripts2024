using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Script : MonoBehaviour
{
    public GameObject obj;
    private GameObject inst_obj;
    [SerializeField]
    private float speed = 4f;


    void Start()
    {
        inst_obj = Instantiate(obj, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
    }


    void Update()
    {
        float zPos = Input.GetAxis("Vertical");

        inst_obj.transform.Translate(Vector3.forward * speed * zPos * Time.deltaTime);
    }
}
