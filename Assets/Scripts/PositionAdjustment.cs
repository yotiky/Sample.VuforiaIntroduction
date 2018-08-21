using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PositionAdjustment : MonoBehaviour
{
    public MarkerTracker marker;
    public GameObject contents;

    void Start()
    {
        marker.Click = m =>
        {
            contents.transform.position = m.position;
            contents.transform.rotation = m.rotation;
            contents.SetActive(true);
            VuforiaBehaviour.Instance.enabled = false;
        };

        contents.SetActive(false);
    }
}
