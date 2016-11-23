using UnityEngine;
using System.Collections;

[AddComponentMenu("State/State manager")]
public class StateManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		EventManager.stateManager = this;
		initialState.setActive (true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setCurrentState(State _current){
		currentState = _current;
	}

	public int getCurrentStateID(){
		return currentState.GetInstanceID();
	}

	public State initialState;
	private State currentState;
}
