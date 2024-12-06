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

    private GameObject grabbed = null;
    private GameObject HoldObj;
    public float action = 3.5f;

    private void Awake()
    {
        interactAction = InputSystem.actions.FindAction("Interact");
    }

    private void Update() {
        if(interactAction.WasPressedThisFrame()) {

            if (grabbableObject == null) {

                //Mains Vides 
                if (Physics.Raycast(raycastOriginTransform.position, raycastOriginTransform.forward, out RaycastHit raycastHit,
                    pickupDistance, pickUpLayerMask)) {

                    if (raycastHit.transform.TryGetComponent(out grabbableObject)) 
                    {
                        HoldObj = raycastHit.transform.gameObject;
                        grabbableObject.Grab(objectGrabPositionTransform);
                        grabbed = null;
                    }
                }
            } 
            else {
                //Transport d'un objet en cours 
                grabbableObject.Drop();
                grabbableObject = null;
                grabbed = HoldObj;
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "RedPaint Station" && grabbed.tag == "Unpainted Toy") // && bool objet tenu + bool objet non paint
        {
            Debug.Log("Station de peinture");
            if (Input.GetKeyDown("E"))
            {
                //animation
                if (Input.GetKeyDown("E") && Time.time > action)
                {
                    grabbed.tag = "Painted Toy";
                    //sprite de l'objet change
                }
            }
        }

        if (other.tag == "BluePaint Station" && grabbed.tag == "Unpainted Toy") // && bool objet tenu + bool objet non paint
        {
            Debug.Log("Station de peinture");
            if (Input.GetKeyDown("E"))
            {
                //animation
                if (Input.GetKeyDown("E") && Time.time > action)
                {
                    grabbed.tag = "Painted Toy";
                    //sprite de l'objet change
                }
            }
        }

        if (other.tag == "GreenPaint Station" && grabbed.tag == "Unpainted Toy") // && bool objet tenu + bool objet non paint
        {
            Debug.Log("Station de peinture");
            if (Input.GetKeyDown("E"))
            {
                //animation
                if (Input.GetKeyDown("E") && Time.time > action)
                {
                    grabbed.tag = "Painted Toy";
                    //sprite de l'objet change
                }
            }
        }

        if (other.tag == "Packaging Station" && grabbed.tag == "Painted Toy")
        {
            Debug.Log("Station d'emballage");
            if (Input.GetKeyDown("E"))
            {
                //animation
                if (Input.GetKeyDown("E") && Time.time > action)
                {
                    grabbed.tag = "Gift";
                    //sprite de l'objet change
                }
            }
        }

        if (other.tag == "Sleigh" && grabbed.tag == "Gift")
        {
            Debug.Log("Traîneaux export");
            if (Input.GetKeyDown("E"))
            {
                Destroy(grabbed);
                //Score système
            }
        }

        if (other.tag == "Sewing Station")
        {
            Debug.Log("Station Couture");
            if (Input.GetKeyDown("E"))
            {
                //animation
                if (Input.GetKeyDown("E") && Time.time > action)
                {
                    grabbed.tag = "Painted Toy";
                    //sprite de l'objet change
                }
            }
        }

        if (other.tag == "Forge" && grabbed.tag == "Iron")
        {
            Debug.Log("Forge");
            if (Input.GetKeyDown("E"))
            {
                //animation
                if (Input.GetKeyDown("E") && Time.time > action)
                {
                    grabbed.tag = "Painted Toy";
                    //sprite de l'objet change
                }
            }
        }

        if (other.tag == "Carpentry" && grabbed.tag == "Wood")
        {
            Debug.Log("Menuiserie");
            if (Input.GetKeyDown("E"))
            {
                //animation
                if (Input.GetKeyDown("E") && Time.time > action)
                {
                    grabbed.tag = "Painted Toy";
                    //sprite de l'objet change
                }
            }
        }

        if (other.tag == "Electronic Station" && grabbed.tag == "Eletric Toy")
        {
            Debug.Log("Station jouets éléctriques");
            if (Input.GetKeyDown("E"))
            {
                //animation
                if (Input.GetKeyDown("E") && Time.time > action)
                {
                    grabbed.tag = "Unpainted Toy";
                    //sprite de l'objet change
                }
            }
        }
    }
}
