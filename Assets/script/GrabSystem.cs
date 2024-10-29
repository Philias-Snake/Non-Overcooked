using Mirror.Examples.MultipleMatch;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GrabSystem : MonoBehaviour
{
    InputAction interactAction;

    // Start is called before the first frame update
    void Start()
    {
        interactAction = InputSystem.actions.FindAction("Interact");
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
        }
    }
}
