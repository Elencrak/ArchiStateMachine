using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class CollisionDetection : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider trigger)
    {
        if(trigger.tag == "sword")
        {
            SceneManager.LoadScene(0);
        }
    }
}
