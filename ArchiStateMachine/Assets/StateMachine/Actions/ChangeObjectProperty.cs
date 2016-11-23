using UnityEngine;
using System.Collections;

[AddComponentMenu("State/Transition actions/Change property")]
public class ChangeObjectProperty : TransitionAction {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public override void OnTransition(){
		if(target){
			Property prop = System.Array.Find<Property> (target.properties, (p) => p.key == property);
			prop.value = newValue;
		}
	}

	public PropertyHolder target;
	public string property;
	public string newValue;
}
