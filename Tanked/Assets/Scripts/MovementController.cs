using UnityEngine;

public class MovementController : MonoBehaviour
{
    float MovementSpeed = 0.1f;
    float RotationSpeed = 1f;
    void FixedUpdate()
    {
        float rotation = 0f;
        if (Input.GetKey(KeyCode.D)) { rotation += RotationSpeed; }
        if (Input.GetKey(KeyCode.A)) { rotation -= RotationSpeed; }
        this.transform.Rotate(Vector3.up, rotation);

        Vector3 forwardOrientation = transform.forward;
        Matrix4x4 objectSpace = Matrix4x4.LookAt(Vector3.zero, forwardOrientation, Vector3.up);

        Vector3 movement = new Vector3();
        if (Input.GetKey(KeyCode.W)) { movement = objectSpace * new Vector3(0, 0, MovementSpeed); }
        if (Input.GetKey(KeyCode.S)) { movement = objectSpace * new Vector3(0, 0, -MovementSpeed); }
        transform.position += movement; 
    }
}
