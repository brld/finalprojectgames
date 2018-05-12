// Especially the Quaternion aspects of this script is thanks to DukeLaze

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perspective : MonoBehaviour
{
    public Canvas canvas;
    Quaternion oldPos;
    float lerpProgress = 0;
    float lerpTime = 10f;

    bool firstperson = true; // Boolean for toggling FP to TP
    Vector3 fpPos = new Vector3(0f, 1f, -6f); // First person position to jump to
    Vector3 tpPos = new Vector3(0f, 3f, -10f); // Third person position to jump to
    float tpAngle = 16f; // Third person angle
    Vector3 tpAxis = new Vector3(1, 0, 0); // Third person axis to determin rotation based off of
    Quaternion tpRot; 
    float fpAngle = 4f; // First person angle
    Vector3 fpAxis = new Vector3(1, 0, 0); // First person axis to determin rotation based off of
    Quaternion fpRot;

    private void Start()
    {
        canvas.enabled = false;
        tpRot = Quaternion.AngleAxis(tpAngle, tpAxis);
        fpRot = Quaternion.AngleAxis(fpAngle, fpAxis);
    }

    // Update is called once per frame
     void Update()
    {
        // Stabilize submarine when colliding with a hill
        Vector3 euler = transform.rotation.eulerAngles;
        Quaternion targetPos = Quaternion.AngleAxis(euler.y, new Vector3(0f,1f,0f));
        transform.rotation = Quaternion.Lerp(oldPos, targetPos, ((lerpProgress + Time.deltaTime) / lerpTime));
        lerpProgress += Time.deltaTime;
        if (lerpProgress > lerpTime)
        {
            lerpProgress = 0f;
        }

        // Handle point of view toggle
        if (Input.GetMouseButtonDown(0))
        {
            Camera.main.transform.localPosition = firstperson ? fpPos : tpPos;
            Camera.main.transform.localRotation = firstperson ? fpRot : tpRot;
            canvas.enabled = firstperson ? true : false; // Enable cockpit overlay
            firstperson = !firstperson;
        }
    }
}