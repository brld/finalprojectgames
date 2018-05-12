using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour {
    Quaternion oldPos;
    float lerpProgress=0;
    float lerpTime = 10f;
    
    // Update is called once per frame
    void Update () {
        oldPos = transform.rotation;
        Quaternion targetPos = new Quaternion(0, oldPos.y, 0, 1);
        transform.rotation = Quaternion.Lerp(oldPos, targetPos, ((lerpProgress+Time.deltaTime)/lerpTime));
        lerpProgress+= Time.deltaTime;
    }
}