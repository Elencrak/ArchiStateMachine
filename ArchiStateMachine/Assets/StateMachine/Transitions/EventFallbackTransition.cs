using UnityEngine;
using System.Collections;

[AddComponentMenu("State/Transitions/Event transition with fallback")]
public class EventFallbackTransition : Transition {

		
	public override void init(){
		EventManager.StartListening(eventName,checkEvent);
	}
	/*public override void deinit(){
		EventManager.StopListening(eventName,checkEvent);
	}*/

	void checkEvent(int _stateId){
		Debug.Log("event called on "+transform.parent.gameObject.name+ " "+_stateId);

		if (_stateId == parentState.GetInstanceID()){
			Condition[] conditions = GetComponents<Condition> ();
			bool allConditionsMet = true;
			foreach (Condition cond in conditions) {
				if (!cond.isMet ()) {
					allConditionsMet = false;
				}
			}

			Debug.Log("   active and conditions met ?" + allConditionsMet);

			if(allConditionsMet)
				OnTransition (target1);
			else
				OnTransition (target2);
		}	
	}
		
	public State target1;
	public State target2;
	public string eventName;
}
