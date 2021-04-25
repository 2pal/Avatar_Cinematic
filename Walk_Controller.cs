using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk_Controller : MonoBehaviour
{

    private Animator Animator1 = null;
    void Start()
    {
        Animator1 = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float Vert = Input.GetAxis("Vertical");
        Animator1.SetFloat("Walk", Vert);
    }
}
