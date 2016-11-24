using UnityEngine;
using System.Collections;

public class RotatePillar : MonoBehaviour {

    void Start()
    {
        propertyHolderPillar = GetComponent<PropertyHolderPillar>();
        propertyHolder = GetComponent<PropertyHolder>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (propertyHolder.GetProperty("activated") == "true")
        {
            leverMesh.transform.rotation = Quaternion.Euler(new Vector3(0, 30, 0));
        }
        else
        {
            leverMesh.transform.rotation = Quaternion.Euler(new Vector3(0, 30, 0));
        }*/
        if(propertyHolder.GetProperty("activated")=="true")
        {
            leverMesh.transform.rotation = Quaternion.Euler(new Vector3(0, propertyHolderPillar.GetProperty("rotate"), 0));
            if(propertyHolderPillar.GetProperty("rotate") == rightValue)
            {
                propertyHolder.SetProperty("rotated", "true");
                if(index < PillarManager.instance.nbOfPillars-1)
                {
                    PillarManager.instance.arrayOfPillars[index+1].SetProperty("activated", "true");
                }
                
            }else
            {
                propertyHolder.SetProperty("rotated", "false");
                if (index < PillarManager.instance.nbOfPillars-1)
                {
                    PillarManager.instance.arrayOfPillars[index+1].SetProperty("activated", "false");
                }
                    
            }
        }
        
    }

    private PropertyHolderPillar propertyHolderPillar;
    private PropertyHolder propertyHolder;
    public GameObject leverMesh;
    public int index;
    public int rightValue;
}
