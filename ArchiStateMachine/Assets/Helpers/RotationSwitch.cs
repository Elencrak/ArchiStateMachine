using UnityEngine;
using System.Collections;

public class RotationSwitch : MonoBehaviour {

	// Use this for initialization
	void Start () {
		propertyHolder = GetComponent<PropertyHolder>();
	}
	
	// Update is called once per frame
	void Update () {
		if(propertyHolder.GetProperty("activated") == "true"){
			leverMesh.transform.rotation = Quaternion.Euler(new Vector3(-30,0,0));
		}else{
			leverMesh.transform.rotation = Quaternion.Euler(new Vector3(30,0,0));
		}
	}

	private PropertyHolder propertyHolder;
	public GameObject leverMesh;
}
