using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    public UIManager uI;
    public float MoveSpeed = 1;
    public float TorqSpeed = 1;
    private Rigidbody _rb;
    private Vector3 _rotator = new Vector3(0,0,0);
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        StartCoroutine(RotatorCoroutine());
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _rb.AddRelativeForce(new Vector3(0, MoveSpeed, 0));
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _rb.AddRelativeForce(new Vector3(0, -MoveSpeed, 0));
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _rb.AddRelativeForce(new Vector3(MoveSpeed, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _rb.AddRelativeForce(new Vector3(-MoveSpeed, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.PageUp))
        {
            _rb.AddRelativeForce(new Vector3(0, 0, MoveSpeed));
        }
        if (Input.GetKeyDown(KeyCode.PageDown))
        {
            _rb.AddRelativeForce(new Vector3(0, 0, -MoveSpeed));
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            _rotator +=(new Vector3(0, TorqSpeed, 0));
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            _rotator +=(new Vector3(0, -TorqSpeed, 0));
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            _rotator +=(new Vector3(-TorqSpeed, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            _rotator +=(new Vector3(TorqSpeed, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            _rotator +=(new Vector3(0, 0, TorqSpeed));
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            _rotator +=(new Vector3(0, 0, -TorqSpeed));
        }
    }

    private IEnumerator RotatorCoroutine()
    {
        while (true)
        {   
            transform.Rotate(_rotator);
            uI.SetTorque(_rotator);
            yield return new WaitForFixedUpdate();
        }
    }
}
