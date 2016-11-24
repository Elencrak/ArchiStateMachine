using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class PropertyPillar{
	public string key;
	public int value;
}

[AddComponentMenu("State/Property holder")]
public class PropertyHolderPillar : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public int GetProperty(string _key){
        PropertyPillar prop = System.Array.Find<PropertyPillar> (properties, (p) => p.key == _key);

		if(prop==null)
			Debug.LogError("Property "+_key+" doesn't exist");
		
		return prop.value;
	}

	public void SetProperty(string _key, int _value){
        PropertyPillar prop = System.Array.Find<PropertyPillar> (properties, (p) => p.key == _key);

		if(prop == null)
			Debug.LogError("Property "+_key+" doesn't exist");
		
		prop.value = _value;
	}

	public PropertyPillar[] properties;
}
