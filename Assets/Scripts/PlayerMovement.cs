using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    public float movementSpeed = 6f;
    //public float turningSpeed = 60;
    private void Start()
    {

        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        //transform.Rotate(0, horizontal, 0);

        float verticalInput = Input.GetAxis("Vertical") ;
        //transform.Translate(0, 0, vertical);
        rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);
    }
}
