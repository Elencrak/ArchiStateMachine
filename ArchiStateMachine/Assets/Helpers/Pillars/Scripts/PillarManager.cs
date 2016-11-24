using UnityEngine;
using System.Collections;

public class PillarManager : MonoBehaviour
{

    private static PillarManager pillarManager;

    public static PillarManager instance
    {
        get
        {
            if (!pillarManager)
            {
                pillarManager = FindObjectOfType(typeof(PillarManager)) as PillarManager;
            }

            return pillarManager;
        }
    }
    public PropertyHolder[] arrayOfPillars;
    public int nbOfPillars = 3;
    void Awake()
    {
        arrayOfPillars = new PropertyHolder[nbOfPillars];
    }


    public void Add(int index, PropertyHolder property)
    {
        arrayOfPillars[index] = property;
    }
}
