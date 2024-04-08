using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mxVal = Input.GetAxis("Mouse X");
        float myVal = Input.GetAxis("Mouse Y");
        if (mxVal != 0)
        {
            float translationFactor = 0.1f;
            float translationX = mxVal * translationFactor;
            transform.Translate(translationX, 0f, 0f);
        }

        if (myVal != 0)
        {
            float translationFactor = 0.1f;
            float translationY = myVal * translationFactor;
            transform.Translate(0f, translationY, 0f);

        }

    }
}
