using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityChecker : MonoBehaviour
{
    public UIManager uI;
    private Rigidbody _rb;
    private Vector3 _preAngle = new Vector3(0,0,0);
    private Vector3 _nowAngle = new Vector3(0,0,0);

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        
    }

    void FixedUpdate()
    {
        _nowAngle = transform.localRotation.eulerAngles;
        uI.SetVelocity(_rb.velocity);
        _preAngle = _nowAngle;
    }
}
