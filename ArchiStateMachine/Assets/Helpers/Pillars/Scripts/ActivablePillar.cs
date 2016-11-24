using UnityEngine;
using System.Collections;

public class ActivablePillar : MonoBehaviour {

	// Use this for initialization
	void Start () {
        propertyHolderPillar = GetComponent<PropertyHolderPillar>();
        propertyHolder = GetComponent<PropertyHolder>();

    }
	
	// Update is called once per frame
	void Update () {

        if (propertyHolder.GetProperty("activated") == "true")
        {
            if(GetComponent<RotatePillar>().index < PillarManager.instance.nbOfPillars-1)
            {
                GetComponent<LineRenderer>().enabled = true;
            }
            
            if (Vector3.Distance(transform.position, player.transform.position) < threshold)
            {

                if (Input.GetKeyDown(KeyCode.Space))
                {
                    
                    int currentValue = propertyHolderPillar.GetProperty("rotate");
                    //propertyHolder.SetProperty("rotate", (currentValue=="true") ? "false" : "true");
                    propertyHolderPillar.SetProperty("rotate", (currentValue += 45) == 360 ? 0 : currentValue);

                    if (emitEvent)
                    {
                        EventManager.TriggerEvent(eventName);
                    }

                }
            }
        }
	
	}

	private PropertyHolderPillar propertyHolderPillar;
    private PropertyHolder propertyHolder;
	public GameObject player;
	public float threshold = 1.0f;
	public bool emitEvent = false;
	public string eventName = "none";
}
