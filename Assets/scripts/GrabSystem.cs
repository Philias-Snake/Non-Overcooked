using Mirror.Examples.MultipleMatch;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class GrabSystem : MonoBehaviour
{
    InputAction interactAction;
    public Transform grabPosition;

    private bool grabing;

    // Start is called before the first frame update
    void Start()
    {
        interactAction = InputSystem.actions.FindAction("Interact");
        grabing = false;
    }
    void Update()
    {
        GrabAction();
    }
    void GrabAction()
    {
        if (interactAction.IsPressed())
        {
            Debug.Log("Boutton Pressé");
            grabing = true;
        }

        while (grabing = true)
        {

        }
    }

    
}
