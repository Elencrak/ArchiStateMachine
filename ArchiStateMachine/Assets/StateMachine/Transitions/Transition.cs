using UnityEngine;
using System.Collections;

[AddComponentMenu("")]
public class Transition : MonoBehaviour {

	// Use this for initialization
	void Start () {
		parentState = GetComponentInParent<State> ();
		init();
	}

	public virtual void init(){}
	//public virtual void deinit(){}

	public void OnTransition(State _target){
		parentState.setActive (false);
		TransitionAction[] actions = GetComponents<TransitionAction> ();
		foreach(TransitionAction action in actions){			
			action.OnTransition();
		}
		_target.setActive (true);
	}

	/*public virtual void OnExitState(){
		deinit();
	}*/

	public virtual void OnEnterState(){
		Condition[] conditions = GetComponents<Condition> ();
		foreach (Condition cond in conditions) {
			cond.Reset (); 
		}
		//init();
	}

	protected State parentState;
}
