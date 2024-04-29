using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    // Declare the Rigidbody component for the physics system
    public Rigidbody _rb;

    // Player variables
    public float forwardForce = 2000f;
    public float sidewayForce = 500f;

    // Start is called before the first frame update
    void Start()
    {
        _rb = this.GetComponent<Rigidbody>();
    }

    // Update for physics system
    void FixedUpdate()
    {
        _rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            _rb.AddForce(sidewayForce * Time.deltaTime, 0, 0);
        }
        else if(Input.GetKey("a"))
        {
            _rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0);
        }
    }
}
