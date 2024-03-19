using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector3 v1 = new Vector3(1, 5, -7);
    private Vector3 v2 = new Vector3(8, 0, -6);

    [SerializeField]
    private int speed;

    private float rotationCount = 0;
    private Vector3 rotation = new Vector3 (0, 1, 0);

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //Дано вектори (1,5,-7) та (8,0,-6). Знайти квадрат довжини їх різниці.
        Vector3 v3 = v1 - v2;
        v3.x = Mathf.Pow(v3.x, 2);
        v3.y = Mathf.Pow(v3.y, 2);
        v3.z = Mathf.Pow(v3.z, 2);
        Debug.Log(v3);
        //
    }

    // Update is called once per frame
    void Update()
    {
        rb.transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * speed;
        if(Input.GetKey(KeyCode.D) && rotationCount != 45)  
        {
            rb.transform.Rotate(rotation, 3);
            rotationCount+=3;
        }
        if (Input.GetKey(KeyCode.A) && rotationCount != -45)
        {
            rb.transform.Rotate(rotation, -3);
            rotationCount-=3;
        }
    }
}
