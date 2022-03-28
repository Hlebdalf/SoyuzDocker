using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KURS : MonoBehaviour
{
    public Transform Target;
    public UIManager uI;
    private Vector3 _dPos;
    private Vector3 _dRot;
    public float PosTreshold = 0.03f;
    private void FixedUpdate()
    {
        _dPos = transform.position - Target.position;
        _dRot = transform.rotation.eulerAngles - Target.rotation.eulerAngles;
        uI.SetKURSRotation(_dRot);
        uI.SetKURSPosition(_dPos);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (_dRot.x < 1 && _dRot.y < 1 && _dRot.z < 1 && _dPos.x < PosTreshold && _dPos.y < PosTreshold && _dPos.z < PosTreshold &&
            _dRot.x > -1 && _dRot.y > -1 && _dRot.z > -1 && _dPos.x > -PosTreshold && _dPos.y > -PosTreshold && _dPos.z > -PosTreshold)
        {
            uI.ShowDock(); 
        }
        else uI.ShowDeath();
        GetComponent<ControllerScript>().Docked();
    }
}