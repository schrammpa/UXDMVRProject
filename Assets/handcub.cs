using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handcub : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("BrickInactive"))
        {
            other.GetComponent<brick>().Activated();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
