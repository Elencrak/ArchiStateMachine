using UnityEngine;
using System.Collections;

[AddComponentMenu("State/State")]
public class State : MonoBehaviour {

	// Use this for initialization
	void Awake(){
		active = false;
	}

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public bool isActive(){
		return active;
	}

	public void setActive(bool _active){
		active = _active;

		if(active){
			EventManager.stateManager.setCurrentState(this);
			Transition[] transitions = GetComponentsInChildren<Transition>();
			foreach(Transition trans in transitions){
				trans.OnEnterState();			
			}
		}

					

	}

	public bool active;
}
