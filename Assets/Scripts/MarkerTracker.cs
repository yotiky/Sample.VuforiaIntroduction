using HoloToolkit.Unity.InputModule;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class MarkerTracker : MonoBehaviour, IInputClickHandler
{
    public Action<Transform> Click { get; set; }

    public void OnInputClicked(InputClickedEventData eventData)
    {
        if(Click != null)
        {
            Click(transform);
        }
    }
}