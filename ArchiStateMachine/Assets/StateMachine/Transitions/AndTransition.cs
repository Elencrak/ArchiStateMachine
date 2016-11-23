using UnityEngine;
using System.Collections;

[AddComponentMenu("State/Transitions/And transition")]
public class AndTransition : Transition {


	// Update is called once per frame
	void Update () {
		if (parentState.isActive ()) {
			Condition[] conditions = GetComponents<Condition> ();
			foreach (Condition cond in conditions) {
				if (!cond.isMet ()) {
					return;
				}
			}
			OnTransition (target);
		}	
	}
		


	public State target;

		
}
