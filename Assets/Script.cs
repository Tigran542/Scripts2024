using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class Script : MonoBehaviour
{
    public GameObject obj;


    void Start()
    {
        Invoke("Inst", 2f);
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.F))
            StartCoroutine(instObj());
    }

    void Inst()
    {
        Instantiate(obj, new Vector3(Random.Range(-10f, 10f), 0f, Random.Range(-10f, 10f)), Quaternion.identity);
    }


    IEnumerator instObj()
    {
        while (true)
        {

            Instantiate(obj, new Vector3(Random.Range(-10f, 10f), 0f, Random.Range(-10f, 10f)), Quaternion.identity);

            yield return new WaitForSeconds(1.5f);
        }
    }
}
