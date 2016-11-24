using UnityEngine;
using System.Collections;

public class SpawnerSphere : MonoBehaviour {
    public GameObject sphere;
    public PropertyHolder pillar;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
        if (pillar.GetProperty("activated") == "true")
        {
            Spawn();
            Destroy(this);
        }
	}

    void Spawn()
    {
        GameObject tempSphere = Instantiate(sphere, transform) as GameObject;
        tempSphere.transform.position = transform.position;
        tempSphere.GetComponent<Rigidbody>().AddForce(-Vector3.down * 100);
       
    }
}
