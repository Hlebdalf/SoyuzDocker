using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KURS : MonoBehaviour
{
    public Transform Target;
    public UIManager uI;
    void Update()
    {
        uI.SetKURSRotation((transform.rotation.eulerAngles - Target.rotation.eulerAngles));
        uI.SetKURSPosition(transform.position - Target.position);
    }
}
