using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    public Text VX;
    public Text VY;
    public Text VZ;

    public Text TX;
    public Text TY;
    public Text TZ;

    public Text PX;
    public Text PY;
    public Text PZ;

    public Text OX;
    public Text OY;
    public Text OZ;

    public void SetVelocity(Vector3 velocity)
    {
        VX.text = velocity.x.ToString();
        VY.text = velocity.y.ToString();
        VZ.text = velocity.z.ToString();
    }

    public void SetTorque(Vector3 torque)
    {
        TX.text = (((int)(torque.x * 100)) / 100f ).ToString();
        TY.text = (((int)(torque.y * 100)) / 100f).ToString();
        TZ.text = (((int)(torque.z * 100)) / 100f).ToString();
    }
    public void SetKURSPosition(Vector3 position)
    {
        PX.text = (((int)(position.x * 100)) / 100f).ToString();
        PY.text = (((int)(position.y * 100)) / 100f).ToString();
        PZ.text = (((int)(position.z * 100)) / 100f).ToString();
    }

    public void SetKURSRotation(Vector3 rotation)
    {
        OX.text = (((int)(rotation.x * 100)) / 100f).ToString();
        OY.text = (((int)(rotation.y * 100)) / 100f).ToString();
        OZ.text = (((int)(rotation.z * 100)) / 100f).ToString();
    }
}
