// Also some thanks to DukeLaze

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleAxis : MonoBehaviour
{
    float angle;
    Vector3 axis;

    // Used to obtain ideal rotation from within game
    void Update()
    {
        Camera.main.transform.rotation.ToAngleAxis(out angle, out axis);
        Debug.Log("Angle: "+angle + " - axis: " + axis);
    }
}