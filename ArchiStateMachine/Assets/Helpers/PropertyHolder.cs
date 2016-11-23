using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class Property{
	public string key;
	public string value;
}

[AddComponentMenu("State/Property holder")]
public class PropertyHolder : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public string GetProperty(string _key){
		Property prop = System.Array.Find<Property> (properties, (p) => p.key == _key);

		if(prop==null)
			Debug.LogError("Property "+_key+" doesn't exist");
		
		return prop.value;
	}

	public void SetProperty(string _key, string _value){
		Property prop = System.Array.Find<Property> (properties, (p) => p.key == _key);

		if(prop == null)
			Debug.LogError("Property "+_key+" doesn't exist");
		
		prop.value = _value;
	}

	public Property[] properties;
}
