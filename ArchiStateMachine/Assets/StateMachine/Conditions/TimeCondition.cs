using UnityEngine;
using System.Collections;

[AddComponentMenu("State/Conditions/Time")]
public class TimeCondition : Condition {

	// Use this for initialization
	void Start () {
		accumulated = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		accumulated += Time.deltaTime;
	}

	public override bool isMet(){
		return accumulated>time;
	}

	public override void Reset(){
		accumulated = 0.0f;
	}

	public float time;
	private float accumulated;
}
