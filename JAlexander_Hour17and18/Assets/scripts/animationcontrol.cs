using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationcontrol : MonoBehaviour
{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetFloat("speed", Input.GetAxis("Vertical"));
        anim.SetFloat("direction", Input.GetAxis("Horizontal"));
    }
}
