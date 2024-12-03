using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerPickUpDrop : MonoBehaviour
{
    [SerializeField] InputAction interactAction;
    [SerializeField] Transform raycastOriginTransform;
    [SerializeField] Transform objectGrabPositionTransform;
    [SerializeField] LayerMask pickUpLayerMask;

    private GrabbableObject grabbableObject;

    public float pickupDistance = 2.0f;

    private void Awake()
    {
        interactAction = InputSystem.actions.FindAction("Interact");
    }

    private void Update()
    {
        
        if(interactAction.IsPressed()) {
            if (grabbableObject = null) {
                //Mains Vides 
                if (Physics.Raycast(raycastOriginTransform.position, raycastOriginTransform.forward, out RaycastHit raycastHit,
                    pickupDistance, pickUpLayerMask))
                {
                    if (raycastHit.transform.TryGetComponent(out GrabbableObject grabbableObject))
                    {
                        grabbableObject.Grab(objectGrabPositionTransform);
                    }
                }
            }
            else
            {
                //Transport d'un objet en cours 
                grabbableObject.Drop();
                grabbableObject = null;
            }
        }
    }
}
