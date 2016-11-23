using UnityEngine;
using System.Collections;

[AddComponentMenu("State/Conditions/Property")]
public class PropertyCheckCondition : Condition {

	// Use this for initialization
	void Start () {
		//defaultValue = target.GetProperty(property);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public override bool isMet(){
		return target.GetProperty(property) == neededValue;
	}

	public override void Reset(){
		//target.SetProperty(property,defaultValue);
	}

	public PropertyHolder target;
	public string property;
	public string neededValue;
	//private string defaultValue;
}
