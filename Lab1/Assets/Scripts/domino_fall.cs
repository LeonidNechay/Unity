using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class domino_fall : MonoBehaviour
{
    [SerializeField] Vector3 rotate;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody>().velocity = rotate;
        }
    }
}
