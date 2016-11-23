using UnityEngine;
using System.Collections;

public class DoorConditionalDisplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		propertyHolder = GetComponent<PropertyHolder>();
	}
	
	// Update is called once per frame
	void Update () {
		if(propertyHolder.GetProperty("opened") == "true"){
			doorMesh.SetActive(false);
		}else{
			doorMesh.SetActive(true);
		}
	}

	private PropertyHolder propertyHolder;
	public GameObject doorMesh;
}
