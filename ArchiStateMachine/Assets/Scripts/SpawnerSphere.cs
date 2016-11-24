using UnityEngine;
using System.Collections;

public class SpawnerSphere : MonoBehaviour {
    public GameObject sphere;

	// Use this for initialization
	void Start () {
	
	}
	


	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Spawn();
        }
	}

    void Spawn()
    {
        GameObject tempSphere = Instantiate(sphere, transform) as GameObject;
        tempSphere.GetComponent<Rigidbody>().AddForce(Vector3.forward * 200);
       
    }
}
