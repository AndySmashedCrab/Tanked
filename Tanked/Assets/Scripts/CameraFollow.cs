using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Transform target;
    public float orbitDistance = 10f;
    public Vector3 cameraHeight = new Vector3(0, 5, 0); // Only change y
    public Vector3 targetHeight = new Vector3(0, 3, 0); // Only change y
    public Vector3 baseCameraOffset = new Vector3(0, 0, 0);
    public Vector3 baseTargetOffset = new Vector3(0, 0, 0);

    void Start()
    {
        target = this.transform.parent;
    }

    void Update()
    {
        Vector3 forwardOrientation = target.transform.forward;
        Matrix4x4 objectSpace = Matrix4x4.LookAt(Vector3.zero, forwardOrientation, Vector3.up);
        Vector3 cameraOffset = objectSpace * baseCameraOffset;
        Vector3 targetOffset = objectSpace * baseTargetOffset;
        Vector3 planarOrientaion = new Vector3(forwardOrientation.x, 0, forwardOrientation.z).normalized;
        this.transform.position = (target.position - planarOrientaion * orbitDistance) + cameraHeight + cameraOffset;
        this.transform.LookAt(target.position + targetHeight + targetOffset);
    }
}
