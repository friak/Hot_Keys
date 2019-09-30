using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkerDetect : MonoBehaviour
{
    private float timeOut = 0;
    void Update()
    {
        
    }

    private void OnEnable()
    {
        if (timeOut >= 0)
        {
            timeOut -= Time.deltaTime;
        }
        else
        {
            timeOut = 25f;
            Debug.Log("hello");
        }
    }

    private void OnDisable()
    {
        if (timeOut >= 0)
        {
            timeOut -= Time.deltaTime;
        }
        else
        {
            timeOut = 25f;
            Debug.Log("bye");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Hello");
    }
}
