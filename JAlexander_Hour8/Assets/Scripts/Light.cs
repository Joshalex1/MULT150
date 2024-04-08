using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{
    public GameObject LightBulb;
    private bool isOn = true;


    void Start()
    {

        LightBulb.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {

            ToggleLight();
        }
    }


    void ToggleLight()
    {

        isOn = !isOn;


        if (isOn)
        {
            LightBulb.SetActive(true);
        }
        else
        {
            LightBulb.SetActive(false);

        }
 

    }
}