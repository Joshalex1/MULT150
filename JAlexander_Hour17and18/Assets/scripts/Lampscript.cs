using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lampscript : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("Color");
        }


        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetTrigger("Scale");
        }


        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetTrigger("Rotate");
        }


        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetTrigger("Position");
        }
    }
}
