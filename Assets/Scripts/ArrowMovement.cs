using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour
{
    public Rigidbody rb;
    public int zForce = 2;
    public float horizontalForce = .001f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, zForce * Time.deltaTime);

        if (Input.GetKey("a"))
        {
            rb.AddForce(-horizontalForce * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey("d"))
        {
            rb.AddForce(horizontalForce * Time.deltaTime, 0, 0);
        }
        else
        {
            rb.AddForce(0, 0, 0);
        }
    }
}
