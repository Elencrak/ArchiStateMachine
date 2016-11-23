using UnityEngine;
using System.Collections;

public class KeyboardController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 movement = new Vector3();
		float rotationY = 0.0f;

		Vector3 forwardDir = transform.TransformDirection(Vector3.forward);
		Vector3 leftDir = transform.TransformDirection(Vector3.left);

		if(Input.GetKey(KeyCode.Z)){
			movement = movement + forwardDir;
		}
		if(Input.GetKey(KeyCode.Q)){
			movement = movement + leftDir;
		}
		if(Input.GetKey(KeyCode.S)){
			movement = movement - forwardDir;
		}
		if(Input.GetKey(KeyCode.D)){
			movement = movement - leftDir;
		}

		if(Input.GetKey(KeyCode.A)){
			rotationY = -1.0f;
		}else if(Input.GetKey(KeyCode.E)){
			rotationY = 1.0f;
		}


		controller.SimpleMove(movement * speedMultiplier);
		transform.Rotate(0.0f,rotationY*rotationMultiplier,0.0f);
	}

	private CharacterController controller;
	public float speedMultiplier = 2.0f;
	public float rotationMultiplier = 2.0f;
}
