﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody rigidBody;
    [SerializeField]
    private float forwardForce = 400f;
    [SerializeField]
    private float sidewaysForce = 400f;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidBody.AddForce(0,0,forwardForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            rigidBody.AddForce(sidewaysForce*Time.deltaTime,0,0);           
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigidBody.AddForce(-sidewaysForce*Time.deltaTime,0,0);           
        }
    }
}