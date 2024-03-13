using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float normalSpeed = 3f;
    [SerializeField]
    private float sprintSpeed = 6f;
    [SerializeField]
    private float sprintTime = 1f;
    [SerializeField]
    bool isSprint = false;
    private float movementSpeed;
    private float t = 0f;


    private void Start()
    {
        movementSpeed = normalSpeed;
    }
    void FixedUpdate()
    {
        if (Input.GetKey("v") && !isSprint)
        {
            isSprint = true;
        }
        if(isSprint)
        {
            movementSpeed = sprintSpeed;
            t += Time.deltaTime;
            if (t > sprintTime)
            {
                isSprint = false;
                movementSpeed = normalSpeed;
                t = 0f;
            }
        }
        if (Input.GetKey("w"))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey("s"))
        {
            transform.position -= transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
        }
        if (Input.GetKey("a") && !Input.GetKey("d"))
        {
                transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
        }
        else if (Input.GetKey("d") && !Input.GetKey("a"))
        {
            transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
        }
    }
}
