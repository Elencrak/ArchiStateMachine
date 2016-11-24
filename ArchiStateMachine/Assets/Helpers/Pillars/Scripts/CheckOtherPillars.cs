using UnityEngine;
using System.Collections;

public class CheckOtherPillars : MonoBehaviour {

    void Start()
    {
        PillarManager.instance.Add(GetComponent<RotatePillar>().index, GetComponent<PropertyHolder>());
    }

    void Update()
    {

    }
	
}
