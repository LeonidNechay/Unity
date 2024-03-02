using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere : MonoBehaviour
{
    public float amplitude = 2f;
    private float frequency = 2f;

    private float x;
    private Rigidbody rb;
    private float startTime;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startTime = Time.time;
        x = (amplitude * (frequency - Mathf.Sin(frequency))) / 10;
        print(x);
    }

    void Update()
    {
        float t = Time.time - startTime;
        float y = amplitude * (1 - Mathf.Cos(frequency * t)) * 50;

        Vector3 newPos = new Vector3(rb.position.x + x, y+1, 0);
        rb.position = newPos;
        //rb.transform.Translate(x, y, 0);
    }
}
