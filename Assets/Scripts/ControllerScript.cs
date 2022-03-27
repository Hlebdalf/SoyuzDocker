using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    public float MoveSpeed = 1;
    public float TorqSpeed = 1;
    private Rigidbody _rb;
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();

    }
    private void Update()
    {
      
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _rb.AddForce(new Vector3(0, MoveSpeed, 0));
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _rb.AddForce(new Vector3(0, -MoveSpeed, 0));
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _rb.AddForce(new Vector3(MoveSpeed, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _rb.AddForce(new Vector3(-MoveSpeed, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.PageUp))
        {
            _rb.AddForce(new Vector3(0, 0, MoveSpeed));
        }
        if (Input.GetKeyDown(KeyCode.PageDown))
        {
            _rb.AddForce(new Vector3(0, 0, -MoveSpeed));
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            _rb.AddTorque(new Vector3(0, TorqSpeed, 0));
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            _rb.AddTorque(new Vector3(0, -TorqSpeed, 0));
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            _rb.AddTorque(new Vector3(-TorqSpeed, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            _rb.AddTorque(new Vector3(TorqSpeed, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _rb.AddTorque(new Vector3(0, 0, TorqSpeed));
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            _rb.AddTorque(new Vector3(0, 0, -TorqSpeed));
        }

    }
}
