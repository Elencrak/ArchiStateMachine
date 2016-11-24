using UnityEngine;
using System.Collections;

public class SpawnerSphere : MonoBehaviour {
    public GameObject sphere;

	// Use this for initialization
	void Start () {
	
	}
	


	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("lol");
            Spawn();
        }
	}

    void Spawn()
    {
        GameObject tempSphere = Instantiate(sphere, transform) as GameObject;
        tempSphere.transform.position = transform.position;
        tempSphere.GetComponent<Rigidbody>().AddForce(-Vector3.down * 200);
       
    }
}
