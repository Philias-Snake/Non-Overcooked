using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
//TODO: faire les commentaires

public class PlayerControllerLocal : MonoBehaviour
{
    PlayerInput PlayerInput;
    InputAction moveAction;
    public float moveSpeed = 5f;
    public Rigidbody PlayerBody;
    void Start()
    {
        PlayerInput = GetComponent<PlayerInput>();
        PlayerBody = GetComponent<Rigidbody>();
        moveAction = PlayerInput.actions.FindAction("move"); 
    }

    void Update()
    {
        MovePlayer();
    }

    private void OnEnable()
    {
        
    }

    void MovePlayer()
    {
        Vector2 direction = moveAction.ReadValue<Vector2>();
        Vector3 moveDirection = new Vector3(direction.x, 0, direction.y) * moveSpeed * Time.deltaTime;
        PlayerBody.AddForce(moveDirection,  ForceMode.Force);
        if (moveDirection != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(moveDirection, Vector3.up);
        }
    }
}
