using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [Header("Viteza personajului")]
    public float speed = 4f;
    [Header("puterea sariturei")]
    public float jumpPower = 200f;

    [Header("Suntem pe pamint?")]
    public bool ground;

    public Rigidbody rb;

    
    void Update()
    {
        GetInput();
    }

    private void GetInput()
    {
        if(Input.GetKey(KeyCode.W))
        {
            transform.localPosition += transform.forward * speed * Time.deltaTime;
        }
        
        if(Input.GetKey(KeyCode.S))
        {
            transform.localPosition += -transform.forward * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += -transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (ground == true)
            {
                rb.AddForce(transform.up * jumpPower);
            }
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            ground= true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            ground = false;
        }
    }

}
