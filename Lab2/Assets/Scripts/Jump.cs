using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float Force = 300f;
    [SerializeField]
    private Vector3 Direction;
    [SerializeField]
    private Rigidbody rb;
    [SerializeField]
    private CheckGround cg;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Direction = transform.up;
        cg = GameObject.FindFirstObjectByType<CheckGround>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && cg.IsOnGround)
        {
            rb.AddForce(Direction * Force);
        }

    }
}
