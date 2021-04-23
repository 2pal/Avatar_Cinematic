using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Transform ThisTransform = null;
    public float speed = 1f;
    public AnimationCurve curve;
    void Awake()
    {
        ThisTransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        ThisTransform.position += speed * ThisTransform.forward * Time.deltaTime;
        float y = curve.Evaluate(Mathf.PingPong(Time.time,a 1f));
        ThisTransform.position = new Vector3(ThisTransform.position.x, y, ThisTransform.position.z);

    }
}
