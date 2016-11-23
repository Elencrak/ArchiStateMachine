using UnityEngine;
using System.Collections;

public class CollisionDetector : MonoBehaviour {

	// Use this for initialization
	void Start () {
		propertyHolder = GetComponent<PropertyHolder>();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider _other){
		if(_other.gameObject.layer == LayerMask.NameToLayer("UI") ){
			propertyHolder.SetProperty(propertyName,"true");
		}
	}

	void OnTriggerExit(Collider _other){
		if(_other.gameObject.layer == LayerMask.NameToLayer("UI") ){
			propertyHolder.SetProperty(propertyName,"false");
		}
	}

	private PropertyHolder propertyHolder;
	public string propertyName = "player_detected";
}
