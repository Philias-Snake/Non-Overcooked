using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
//TODO: faire les commentaires

public class PlayerControllerLocal : MonoBehaviour
{
    //init player input
    PlayerInput PlayerInput;
    InputAction moveAction;
    //init rigid body
    Rigidbody PlayerBody;
    //vitesse de deplacemnt du joueur
    public float moveSpeed;
    void Start()
    {
        //find component
        PlayerInput = GetComponent<PlayerInput>();
        PlayerBody = GetComponent<Rigidbody>();
        moveAction = PlayerInput.actions.FindAction("move"); 
    }

    void Update()
    {
        //call moveplayer methode 
        MovePlayer();
    }

    private void OnEnable()
    {
        
    }

    void MovePlayer()
    {
        //grab player input
        Vector2 direction = moveAction.ReadValue<Vector2>();
        //debug
        Debug.Log(moveSpeed);
        //transform vector 2 in vector 2 for ease of use
        Vector3 moveDirection = new Vector3(direction.x, 0, direction.y) * (moveSpeed * Time.deltaTime);
        // apply movement
        PlayerBody.AddForce(moveDirection,  ForceMode.VelocityChange);
        //rotation player
        if (moveDirection != Vector3.zero)
        {
            //apply rotation
            transform.rotation = Quaternion.LookRotation(moveDirection, Vector3.up);
        }
    }
}
