using UnityEngine;
using System.Collections;

public class RotateAxe : MonoBehaviour {

    public float speed;
    Quaternion initialRotation;
    public GameObject objectToRotateAround;
    public float angleMax;
    public float period;
    public float rotationOffset;

    void Update()
    {

        float angle = angleMax * Mathf.Cos(2 * Mathf.PI / period * Time.time) + rotationOffset;

        transform.localRotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

}
