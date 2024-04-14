using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TRIGGERSCRIPT1 : MonoBehaviour
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
        count++;
        if (other.gameObject.name == "LTrigger")
        {
            Debug.Log("LTrigger activated");
        }
        else if (other.gameObject.name == "RTrigger")
        {
            Debug.Log("RTrigger activated");
        }
        Debug.Log(other.gameObject.name + " has entered the trigger");

        Debug.Log(" Total Trigger Activations: " + count);
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log(other.gameObject.name + " is still in the trigger");
        count++;
        if (other.gameObject.name == "LTrigger")
        {
            Debug.Log("LTrigger activated");
        }
        else if (other.gameObject.name == "RTrigger")
        {
            Debug.Log("RTrigger activated");
        }
        Debug.Log(other.gameObject.name + " has entered the trigger");

        Debug.Log(" Total Trigger Activations: " + count);
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.name + " has left the trigger");
        count++;
        if (other.gameObject.name == "LTrigger")
        {
            Debug.Log("LTrigger activated");
        }
        else if (other.gameObject.name == "RTrigger")
        {
            Debug.Log("RTrigger activated");
        }
        Debug.Log(other.gameObject.name + " has entered the trigger");

        Debug.Log(" Total Trigger Activations: " + count);
    }
}
