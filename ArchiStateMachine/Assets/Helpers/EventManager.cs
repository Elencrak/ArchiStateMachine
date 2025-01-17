using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class StateEvent : UnityEvent<int>
{
}

public class EventManager : MonoBehaviour {

	private Dictionary <string, StateEvent > eventDictionary;
	private static EventManager eventManager;
	public static StateManager stateManager;

    public static EventManager instance{
        get{
            if (!eventManager){
                eventManager = FindObjectOfType (typeof (EventManager)) as EventManager;

                if (!eventManager){
                    Debug.LogError ("There needs to be one active EventManger script on a GameObject in your scene.");
                }
                else{
                    eventManager.Init (); 
                }
            }

            return eventManager;
        }
    }

    void Init (){
        if (eventDictionary == null){
			eventDictionary = new Dictionary<string, StateEvent >();
        }
    }

	public static void StartListening (string eventName, UnityAction<int> listener){
		StateEvent thisEvent = null;
        if (instance.eventDictionary.TryGetValue (eventName, out thisEvent)){
            thisEvent.AddListener (listener);
        } 
        else{
			thisEvent = new StateEvent();
            thisEvent.AddListener (listener);
            instance.eventDictionary.Add (eventName, thisEvent);
        }
    }

	public static void StopListening (string eventName, UnityAction<int> listener){
        if (eventManager == null) return;
		StateEvent thisEvent = null;
        if (instance.eventDictionary.TryGetValue (eventName, out thisEvent)){
            thisEvent.RemoveListener (listener);
        }
    }

    public static void TriggerEvent (string eventName){
		StateEvent thisEvent = null;
        if (instance.eventDictionary.TryGetValue (eventName, out thisEvent)){
			int currentStateId = stateManager.getCurrentStateID();

			Debug.Log("Triggering event "+eventName);
			thisEvent.Invoke (currentStateId);
        }
    }
}