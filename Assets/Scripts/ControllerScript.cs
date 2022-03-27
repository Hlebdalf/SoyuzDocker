using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    public UIManager uI;
    public float MoveSpeed = 1;
    public float TorqSpeed = 1;
    private Vector3 _rotator = new Vector3(0, 0, 0);
    private Vector3 _positor = new Vector3(0, 0, 0);
    private void Start()
    {
        StartCoroutine(MoverCoroutine());
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {   
            _positor +=(new Vector3(0, MoveSpeed, 0));
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _positor +=(new Vector3(0, -MoveSpeed, 0));
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _positor +=(new Vector3(MoveSpeed, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _positor +=(new Vector3(-MoveSpeed, 0, 0));
        }
        if (Input.GetKeyDown(KeyCode.PageUp))
        {
            _positor +=(new Vector3(0, 0, MoveSpeed));
        }
        if (Input.GetKeyDown(KeyCode.PageDown))
        {
            _positor +=(new Vector3(0, 0, -MoveSpeed));
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

    private IEnumerator MoverCoroutine()
    {
        while (true)
        {   
            transform.Rotate(_rotator);
            transform.Translate(_positor);
            uI.SetTorque(_rotator);
            uI.SetVelocity(_positor);
            yield return new WaitForFixedUpdate();
        }
    }
}
