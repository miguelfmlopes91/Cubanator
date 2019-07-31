using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    Rigidbody rigidBody;
    [SerializeField]
    private float forwardForce = 400f;
    [SerializeField]
    private float sidewaysForce = 100f;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidBody.AddForce(0,0,forwardForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            rigidBody.AddForce(sidewaysForce*Time.deltaTime,0,0, ForceMode.VelocityChange);           
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigidBody.AddForce(-sidewaysForce*Time.deltaTime,0,0,ForceMode.VelocityChange);           
        }
        if (rigidBody.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
