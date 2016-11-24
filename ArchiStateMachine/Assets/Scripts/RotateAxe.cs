using UnityEngine;
using System.Collections;

public class RotateAxe : MonoBehaviour {

    public float speed;
    Quaternion initialRotation;
    public GameObject objectToLookAt;
    public float angleMin;
    public float angleMax;

    public bool isMoving;
    float offset = 5;
	// Use this for initialization
	void Start () {
        initialRotation = this.transform.rotation;
        transform.eulerAngles= new Vector3(0, 0, angleMin);
	}

    void Update()
    {
            if(transform.eulerAngles.z >= angleMax && transform.eulerAngles.z >= angleMin)
            {
                transform.RotateAround(objectToLookAt.transform.position, -Vector3.forward, speed * Time.deltaTime);
            }

            if(transform.eulerAngles.z <= angleMax)
            {
                transform.RotateAround(objectToLookAt.transform.position, Vector3.forward, speed * Time.deltaTime);
            }
        
    }


    IEnumerator Move(bool invert)
    {
        isMoving = true;
        if (invert)
        {
            Debug.Log(transform.eulerAngles.z);
            while (transform.eulerAngles.z <= angleMax + offset && transform.eulerAngles.z >= angleMin - 1)
            {
                transform.RotateAround(objectToLookAt.transform.position, -Vector3.forward, speed * Time.deltaTime);
                yield return new WaitForEndOfFrame();
            }
        }
        else
        {
            while (transform.eulerAngles.z >= angleMin - offset && transform.eulerAngles.z <= angleMax + 1)
            {
                transform.RotateAround(objectToLookAt.transform.position, Vector3.forward, speed * Time.deltaTime);
                yield return new WaitForEndOfFrame();
            }
        }
        isMoving = false;
    }
}
