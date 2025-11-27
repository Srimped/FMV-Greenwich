using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using CharlesEngine;

public class StatusBar : MonoBehaviour
{
    public GameObject[] statusPoint;

    public int statusValue;

    public IntVariable value;
    void Start()
    {
        UpdateStatus();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateStatus();
        StatusBarFiller();
    }

    void UpdateStatus()
    {
        statusValue = value.GetValue();
    }

    void StatusBarFiller()
    {
        if (statusPoint == null)
            Debug.LogError("Status element is missing");

        for (int i = 0; i < statusPoint.Length; i++)
        {
            statusPoint[i].SetActive(!DisplayStatusPoint(statusValue, i));
        }
    }

    bool DisplayStatusPoint(int _statusValue, int pointNumber)
    {
        return (pointNumber >= statusValue);
    }
}
