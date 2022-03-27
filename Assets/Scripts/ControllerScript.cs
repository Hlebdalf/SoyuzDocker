using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    public UIManager uI;
    public float MoveSpeed = 1;
    public float TorqueSpeed = 1;
    private float _ms = 1;
    private float _ts = 1;
    private Vector3 _rotator = new Vector3(0, 0, 0);
    private Vector3 _positor = new Vector3(0, 0, 0);
    private void Start()
    {
        StartCoroutine(MoverCoroutine());
    }
    private void Update()
    {

        if (Input.anyKey)
        {
            _ms = MoveSpeed * Random.Range(0.95f, 1.05f);
            _ts = TorqueSpeed * Random.Range(0.95f, 1.05f);

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                _positor += (new Vector3(0, _ms, 0));
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                _positor += (new Vector3(0, -_ms, 0));
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                _positor += (new Vector3(_ms, 0, 0));
            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                _positor += (new Vector3(-_ms, 0, 0));
            }
            if (Input.GetKeyDown(KeyCode.PageUp))
            {
                _positor += (new Vector3(0, 0, _ms));
            }
            if (Input.GetKeyDown(KeyCode.PageDown))
            {
                _positor += (new Vector3(0, 0, -_ms));
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                _rotator += (new Vector3(0, _ts, 0));
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                _rotator += (new Vector3(0, -_ts, 0));
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                _rotator += (new Vector3(-_ts, 0, 0));
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                _rotator += (new Vector3(_ts, 0, 0));
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                _rotator += (new Vector3(0, 0, _ts));
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                _rotator += (new Vector3(0, 0, -_ts));
            }
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
