using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    // Declare the Rigidbody component for the physics system
    public Rigidbody _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = this.GetComponent<Rigidbody>();
    }

    // Update for physics system
    void FixedUpdate()
    {
        _rb.AddForce(0, 0, 2000 * Time.deltaTime);
    }
}
