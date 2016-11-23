using UnityEngine;
using System.Collections;

public class Activable : MonoBehaviour {

	// Use this for initialization
	void Start () {
		propertyHolder = GetComponent<PropertyHolder>();
	}
	
	// Update is called once per frame
	void Update () {
		if( Vector3.Distance(transform.position,player.transform.position) < threshold){
			if(Input.GetKeyDown(KeyCode.Space)){
				string currentValue = propertyHolder.GetProperty("activated");
				propertyHolder.SetProperty(	"activated",   
											(currentValue=="true") ? "false" : "true");

				if(emitEvent){
					EventManager.TriggerEvent(eventName);
				}
			}
		}
	
	}

	private PropertyHolder propertyHolder;
	public GameObject player;
	public float threshold = 1.0f;
	public bool emitEvent = false;
	public string eventName = "none";
}
