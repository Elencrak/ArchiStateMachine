using UnityEngine;
using System.Collections;

[AddComponentMenu("")]
public class Condition : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public virtual void Reset(){

	}

	public virtual bool isMet(){
		return false;
	}
}
