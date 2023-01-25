using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public Rigidbody rb; //Component reference

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    // Start is called before the first frame update
    /*void Start()
    {
        //Debug.Log("Hello, World"); Script console test
        //rb.useGravity = false; Rigidbody script test
        rb.AddForce(0, 200, 500);
    }*/

    // Update is called once per frame
    void FixedUpdate() //FixedUpdate() used for physics related things (Unity likes this as opposed to Update()
    {
        //Added forwardForce 
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d")) {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f) 
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
