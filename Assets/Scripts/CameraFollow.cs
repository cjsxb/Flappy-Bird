using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    // Update is called once per frame
    void Update()
    {
        if (target == null)
            return;

        Vector3 camPos = transform.position;
        Vector3 targetPos = target.position;
        camPos = new Vector3(targetPos.x, camPos.y, camPos.z);
        transform.position = camPos;

    }
}