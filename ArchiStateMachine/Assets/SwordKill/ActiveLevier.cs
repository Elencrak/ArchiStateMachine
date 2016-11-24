using UnityEngine;
using System.Collections;

public class ActiveLevier : MonoBehaviour {

    private PropertyHolder propertyHolder;
    public PropertyHolder refToActive;
    // Use this for initialization
    void Start () {
        propertyHolder = GetComponent<PropertyHolder>();
    }
	
	// Update is called once per frame
	void Update () {
        if (propertyHolder.GetProperty("activated") == "true")
        {
            refToActive.SetProperty("opened", "true");
        }
        else if (propertyHolder.GetProperty("activated") == "false")
        {
            refToActive.SetProperty("opened", "false");
        }
    }
}
