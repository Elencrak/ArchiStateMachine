using UnityEngine;
using System.Collections;

[AddComponentMenu("State/Transition actions/Play sound")]
public class PlaySoundAction : TransitionAction {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public override void OnTransition(){
		if(audioClip != null){			
			AudioSource.PlayClipAtPoint(audioClip,transform.position);
		}

	}

	public AudioClip audioClip;
	//public Vector3 pos;
}
