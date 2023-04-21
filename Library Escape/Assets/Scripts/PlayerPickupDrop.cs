using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPickupDrop : MonoBehaviour
{
    [SerializeField] private Transform playerCameraTransform;
    [SerializeField] private LayerMask pickupLayerMask;
    public float pickupDistance = 2.0f;
    public GameObject statue1;
    public GameObject statue2;
    public GameObject statue3;
    public GameObject statue4;
    public Transform plate1;
    public Transform plate2;
    public Transform plate3;
    public Transform plate4; 
    public Transform extraPlate;
    // Start is called before the first frame update
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Physics.Raycast(playerCameraTransform.position, playerCameraTransform.forward, out RaycastHit raycastHit, pickupDistance, pickupLayerMask))
            {
                if (raycastHit.transform.TryGetComponent(out ObjectGrabbable objectGrabbable))
                {
                    
                    if (objectGrabbable.name == "Door")
                    {
                        KeypadCanvas.keypadEnabled = true;
                        
                    }
                    else if (objectGrabbable.name == "BronzeKey")
                    {
                        Destroy(objectGrabbable.gameObject);
                        Keys.bronzeKey = true;
                    }
                    else if (objectGrabbable.name == "SilverKey")
                    {
                        Destroy(objectGrabbable.gameObject);
                        Keys.silverKey = true;
                    }
                    else if (objectGrabbable.name == "GoldKey")
                    {
                        Destroy(objectGrabbable.gameObject);
                        Keys.goldKey = true;
                    }
                    else if (objectGrabbable.name == "Statue1" || objectGrabbable.name == "Statue1(Clone)" && StatuePuzzle.puzzleComplete == false)
                    {
                        if (StatuePuzzle.isHoldingStatueTwo == false && StatuePuzzle.isHoldingStatueThree == false && StatuePuzzle.isHoldingStatueFour == false)
                        {
                            Destroy(objectGrabbable.gameObject);
                            StatuePuzzle.isHoldingStatueOne = true; 
                        }
                        
                    }
                    else if (objectGrabbable.name == "Statue2" || objectGrabbable.name == "Statue2(Clone)" && StatuePuzzle.puzzleComplete == false)
                    {
                        if (StatuePuzzle.isHoldingStatueOne == false && StatuePuzzle.isHoldingStatueThree == false && StatuePuzzle.isHoldingStatueFour == false)
                        {
                            Destroy(objectGrabbable.gameObject);
                            StatuePuzzle.isHoldingStatueTwo = true;
                        }
                    }
                    else if (objectGrabbable.name == "Statue3" || objectGrabbable.name == "Statue3(Clone)" && StatuePuzzle.puzzleComplete == false)
                    {
                        if (StatuePuzzle.isHoldingStatueTwo == false && StatuePuzzle.isHoldingStatueOne == false && StatuePuzzle.isHoldingStatueFour == false)
                        {
                            Destroy(objectGrabbable.gameObject);
                            StatuePuzzle.isHoldingStatueThree = true;
                        }
                    }
                    else if (objectGrabbable.name == "Statue4" || objectGrabbable.name == "Statue4(Clone)" && StatuePuzzle.puzzleComplete == false)
                    {
                        if (StatuePuzzle.isHoldingStatueTwo == false && StatuePuzzle.isHoldingStatueOne == false && StatuePuzzle.isHoldingStatueThree == false)
                        {
                            Destroy(objectGrabbable.gameObject);
                            StatuePuzzle.isHoldingStatueFour = true;
                        }
                    }
                }
                else if (raycastHit.transform.TryGetComponent(out ObjectReadable objectReadable))
                {
                    if (objectReadable.name == "Book")
                    {
                        BookUI.isBook = true; 
                    }
                    /*switch (objectReadable.name)
                    {

                    }*/
                }
                else if (raycastHit.transform.TryGetComponent(out LockedObject lockedObject))
                {
                    LockedText.enableText = true;
                    
                }
                else if (raycastHit.transform.TryGetComponent(out ObjectPlaceable objectPlaceable))
                {
                    if (objectPlaceable.name == "PressurePlate1" && StatuePuzzle.puzzleComplete == false)
                    {
                        Debug.Log("1 Placed");
                        if (StatuePuzzle.isHoldingStatueOne == true)
                        {
                            StatuePuzzle.isHoldingStatueOne = false;
                            Instantiate(statue1, plate1.position, Quaternion.identity);
                            StatuePuzzle.statueOnFirst = 1;
                        }
                        else if (StatuePuzzle.isHoldingStatueTwo == true)
                        {
                            StatuePuzzle.isHoldingStatueTwo = false;
                            Instantiate(statue2, plate1.position, Quaternion.identity);
                            StatuePuzzle.statueOnFirst = 2;
                        }
                        else if (StatuePuzzle.isHoldingStatueThree == true)
                        {
                            StatuePuzzle.isHoldingStatueThree = false;
                            Instantiate(statue3, plate1.position, Quaternion.identity);
                            StatuePuzzle.statueOnFirst = 3;
                        }
                        else if (StatuePuzzle.isHoldingStatueFour == true)
                        {
                            StatuePuzzle.isHoldingStatueFour = false;
                            Instantiate(statue4, plate1.position, Quaternion.identity);
                            StatuePuzzle.statueOnFirst = 4;
                        }
                    }
                    else if (objectPlaceable.name == "PressurePlate2" && StatuePuzzle.puzzleComplete == false)
                    {
                        Debug.Log("2 Placed");
                        if (StatuePuzzle.isHoldingStatueOne == true)
                        {
                            StatuePuzzle.isHoldingStatueOne = false;
                            Instantiate(statue1, plate2.position, Quaternion.identity);
                            StatuePuzzle.statueOnSecond = 1;
                        }
                        else if (StatuePuzzle.isHoldingStatueTwo == true)
                        {
                            StatuePuzzle.isHoldingStatueTwo = false;
                            Instantiate(statue2, plate2.position, Quaternion.identity);
                            StatuePuzzle.statueOnSecond = 2;
                        }
                        else if (StatuePuzzle.isHoldingStatueThree == true)
                        {
                            StatuePuzzle.isHoldingStatueThree = false;
                            Instantiate(statue3, plate2.position, Quaternion.identity);
                            StatuePuzzle.statueOnSecond = 3;
                        }
                        else if (StatuePuzzle.isHoldingStatueFour == true)
                        {
                            StatuePuzzle.isHoldingStatueFour = false;
                            Instantiate(statue4, plate2.position, Quaternion.identity);
                            StatuePuzzle.statueOnSecond = 4;
                        }
                    }
                    else if (objectPlaceable.name == "PressurePlate3" && StatuePuzzle.puzzleComplete == false)
                    {
                        Debug.Log("3 Placed");
                        if (StatuePuzzle.isHoldingStatueOne == true)
                        {
                            StatuePuzzle.isHoldingStatueOne = false;
                            Instantiate(statue1, plate3.position, Quaternion.identity);
                            StatuePuzzle.statueOnThird = 1;
                        }
                        else if (StatuePuzzle.isHoldingStatueTwo == true)
                        {
                            StatuePuzzle.isHoldingStatueTwo = false;
                            Instantiate(statue2, plate3.position, Quaternion.identity);
                            StatuePuzzle.statueOnThird = 2;
                        }
                        else if (StatuePuzzle.isHoldingStatueThree == true)
                        {
                            StatuePuzzle.isHoldingStatueThree = false;
                            Instantiate(statue3, plate3.position, Quaternion.identity);
                            StatuePuzzle.statueOnThird = 3;
                        }
                        else if (StatuePuzzle.isHoldingStatueFour == true)
                        {
                            StatuePuzzle.isHoldingStatueFour = false;
                            Instantiate(statue4, plate3.position, Quaternion.identity);
                            StatuePuzzle.statueOnThird = 4;
                        }
                    }
                    else if (objectPlaceable.name == "PressurePlate4" && StatuePuzzle.puzzleComplete == false)
                    {
                        Debug.Log("1 Placed");
                        if (StatuePuzzle.isHoldingStatueOne == true)
                        {
                            StatuePuzzle.isHoldingStatueOne = false;
                            Instantiate(statue1, plate4.position, Quaternion.identity);
                            StatuePuzzle.statueOnFourth = 1;
                        }
                        else if (StatuePuzzle.isHoldingStatueTwo == true)
                        {
                            StatuePuzzle.isHoldingStatueTwo = false;
                            Instantiate(statue2, plate4.position, Quaternion.identity);
                            StatuePuzzle.statueOnFourth = 2;
                        }
                        else if (StatuePuzzle.isHoldingStatueThree == true)
                        {
                            StatuePuzzle.isHoldingStatueThree = false;
                            Instantiate(statue3, plate4.position, Quaternion.identity);
                            StatuePuzzle.statueOnFourth = 3;
                        }
                        else if (StatuePuzzle.isHoldingStatueFour == true)
                        {
                            StatuePuzzle.isHoldingStatueFour = false;
                            Instantiate(statue4, plate4.position, Quaternion.identity);
                            StatuePuzzle.statueOnFourth = 4; 
                        }
                    }
                    else if (objectPlaceable.name == "ExtraPlate")
                    {
                        Debug.Log("3 Placed");
                        if (StatuePuzzle.isHoldingStatueOne == true)
                        {
                            StatuePuzzle.isHoldingStatueOne = false;
                            Instantiate(statue1, extraPlate.position, Quaternion.identity);
                        }
                        else if (StatuePuzzle.isHoldingStatueTwo == true)
                        {
                            StatuePuzzle.isHoldingStatueTwo = false;
                            Instantiate(statue2, extraPlate.position, Quaternion.identity);
                        }
                        else if (StatuePuzzle.isHoldingStatueThree == true)
                        {
                            StatuePuzzle.isHoldingStatueThree = false;
                            Instantiate(statue3, extraPlate.position, Quaternion.identity);
                        }
                        else if (StatuePuzzle.isHoldingStatueFour == true)
                        {
                            StatuePuzzle.isHoldingStatueFour = false;
                            Instantiate(statue4, extraPlate.position, Quaternion.identity);
                        }
                    }
                }
            }
            
        }
    }
}
