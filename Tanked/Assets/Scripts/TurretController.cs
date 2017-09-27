using UnityEngine;

public class TurretController : MonoBehaviour
{
    float RotationSpeed = 0.5f;
    float limit = 999;
    float currentRotation = 0;
    void FixedUpdate()
    {
        float rotation = 0f;
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (currentRotation < limit)
            {
                rotation += RotationSpeed;
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (currentRotation > -limit)
            {
                rotation -= RotationSpeed;
            }
        }
        currentRotation += rotation;
        this.transform.Rotate(Vector3.up, rotation);
    }
}