using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPickupDrop : MonoBehaviour
{
    [SerializeField] private Transform playerCameraTransform;
    [SerializeField] private LayerMask pickupLayerMask;
    public float pickupDistance = 2.0f;
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
                    else if (objectGrabbable.name == "Key")
                    {
                        Destroy(objectGrabbable.gameObject);
                    }

                    else if (objectGrabbable.name == "Statue1")
                    {
                        Destroy(objectGrabbable.gameObject);
                    }
                    else if (objectGrabbable.name == "Statue2")
                    {
                        Destroy(objectGrabbable.gameObject);
                    }
                    else if (objectGrabbable.name == "Statue3")
                    {
                        Destroy(objectGrabbable.gameObject);
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
                else if (raycastHit.transform.TryGetComponent(out ObjectPlaceable objectPlaceable))
                {
                    if (objectPlaceable.name == "PressurePlate1")
                    {
                        Debug.Log("1 Placed");
                    }
                    else if (objectPlaceable.name == "PressurePlate2")
                    {
                        Debug.Log("2 Placed");
                    }
                    else if (objectPlaceable.name == "PressurePlate3")
                    {
                        Debug.Log("3 Placed");
                    }
                }
            }
            
        }
    }
}
