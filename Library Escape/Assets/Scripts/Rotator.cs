using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] Vector3 rotation;
    public static bool placeGorgon = false;
    public static bool placeKnight = false;
    public static bool placePirate = false;
    public static bool placeWizard = false; 
    public GameObject statue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if (placeGorgon == true)
        {
            PlayerPickupDrop.statue1Clone.transform.Rotate(rotation);
            placeGorgon = false;
        }
        else if (placeKnight == true)
        {
            PlayerPickupDrop.statue2Clone.transform.Rotate(rotation);
            placeKnight = false; 
        }
        else if (placePirate == true)
        {
            PlayerPickupDrop.statue3Clone.transform.Rotate(rotation);
            placePirate = false;
        }
        else if (placeWizard == true)
        {
            PlayerPickupDrop.statue4Clone.transform.Rotate(rotation);
            placeWizard = false;
        }
    }
}
