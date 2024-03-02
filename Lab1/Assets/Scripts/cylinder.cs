using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinder : MonoBehaviour
{
    [SerializeField] Vector3 rotate;
    [SerializeField] Vector3 point;
    [SerializeField] float degree;

    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.transform.RotateAround(point, rotate, degree);
    }
}
