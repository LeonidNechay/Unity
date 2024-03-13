using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{
    private int dashValue = 3;
    private float dashCooldown = 5;
    private float time = 0;
    private float Force = 10;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(dashValue);
        if(dashValue > 0)
        {
            if(Input.GetKeyDown(KeyCode.LeftShift))
            {
                transform.position += transform.TransformDirection(Vector3.forward * Force);
                dashValue -= 1;
            }
        }
        if(dashValue < 3) 
        {
            if(time >= dashCooldown)
            {
                dashValue++;
                time = 0;
            }
            time += Time.deltaTime;
        }
    }
}
