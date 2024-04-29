using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The target object to follow
    public float smoothSpeed = 0.125f; // The speed at which the camera follows the target
    public Vector3 offset; // The offset from the target
    public bool doLookAt = false;

    void Update()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
            // Move the camera towards the desired position using Translate
            transform.Translate((desiredPosition - transform.position) * smoothSpeed * Time.deltaTime, Space.World);
            if(doLookAt)
            transform.LookAt(target); // Make the camera look at the target
        }
    }
}
