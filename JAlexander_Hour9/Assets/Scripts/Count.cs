using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
  }

    int count = 0;
    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.name + " has entered the cube");

        count++;
        Debug.Log("Total times :" + count);
    }
}
