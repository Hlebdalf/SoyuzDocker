using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time : MonoBehaviour
{
    private Text _timer;
    private int _hours;
    private int _minutes;
    private int _seconds;
    private int _mlseconds;
    void Start()
    {
        _timer = GetComponent<Text>();
    }

    void FixedUpdate()
    {
        _hours = System.DateTime.Now.Hour;
        _minutes = System.DateTime.Now.Minute;
        _seconds = System.DateTime.Now.Second;
        _mlseconds = System.DateTime.Now.Millisecond;
        _timer.text = _hours.ToString() + ":" + _minutes.ToString() + ":" + _seconds.ToString() + ":" + _mlseconds.ToString();
    }
}
