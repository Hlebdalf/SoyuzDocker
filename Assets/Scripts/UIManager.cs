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
}
