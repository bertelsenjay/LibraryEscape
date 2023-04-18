using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
                    Destroy(objectGrabbable.gameObject);
                    /*switch(objectGrabbable.name)
                    {
                        
                    }*/
                }
                else if (raycastHit.transform.TryGetComponent(out ObjectReadable objectReadable))
                {
                    /*switch (objectReadable.name)
                    {

                    }*/
                }
            }
        }
    }
}
