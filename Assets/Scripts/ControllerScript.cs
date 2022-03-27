using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    private Rigidbody _rb;
    private Vector3 _velocity;
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();

    }
    private void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _velocity.y += 1;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _velocity.y -= 1;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _velocity.x += 1;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _velocity.x -= 1;
        }
        if (Input.GetKeyDown(KeyCode.PageUp))
        {
            _velocity.z += 1;
        }
        if (Input.GetKeyDown(KeyCode.PageDown))
        {
            _velocity.z -= 1;
        }


    */
        
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _rb.AddForce(new Vector3(0, 1, 0));
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _rb.AddForce(new Vector3(0, -1, 0));
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _rb.AddForce(new Vector3(1, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _rb.AddForce(new Vector3(-1, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.PageUp))
        {
            _rb.AddForce(new Vector3(0, 0, 1));
        }
        if (Input.GetKeyDown(KeyCode.PageDown))
        {
            _rb.AddForce(new Vector3(0, 0, -1));
        }

    }
    private void FixedUpdate()
    {
        //_rb.velocity = _velocity;
    }
}
