using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    float RotationSpeed = 0.5f;
    float lowerLimit = -5;
    float upperLimit = 40;
    float currentRotation = 0;

    void FixedUpdate()
    {
        float rotation = 0f;
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (currentRotation < upperLimit)
            {
                rotation -= RotationSpeed;
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (currentRotation > lowerLimit)
            {
                rotation += RotationSpeed;
            }
        }
        currentRotation -= rotation;
        this.transform.Rotate(Vector3.right, rotation);
    }
}
