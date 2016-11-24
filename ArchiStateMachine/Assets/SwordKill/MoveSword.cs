using UnityEngine;
using System.Collections;

public class MoveSword : MonoBehaviour {

    public float distance;
    public float direction;
    public float swordSpeed;
    private Vector3 reachPosition;
    private Vector3 startPosition;

    private PropertyHolder propertyHolder;
    // Use this for initialization
    void Start () {
        reachPosition = new Vector3(transform.position.x, transform.position.y + (distance * direction), transform.position.z);
        startPosition = transform.position;
        propertyHolder = GetComponent<PropertyHolder>();
    }
	
	// Update is called once per frame
	void Update () {
        if(propertyHolder.GetProperty("sword_trap") == "true")
        {
            transform.position = Vector3.Lerp(transform.position, reachPosition, swordSpeed * Time.deltaTime);
        }
        else if (propertyHolder.GetProperty("sword_trap") == "false")
        {
            transform.position = Vector3.Lerp(transform.position, startPosition, swordSpeed * Time.deltaTime);
        }
	}
}
