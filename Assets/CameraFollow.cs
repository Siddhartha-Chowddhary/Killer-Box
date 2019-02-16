using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform target;
    public float SmoothSpeed = 0.125f;
    public Vector3 Offset;

    void LateUpdate()
    {
        transform.position = target.position + Offset;   
    }

}
