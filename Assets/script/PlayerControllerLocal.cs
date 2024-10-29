using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerLocal : MonoBehaviour
{
    PlayerInput PlayerInput;
    InputAction moveAction;
    public float moveSpeed = 5f;
    void Start()
    {
        PlayerInput = GetComponent<PlayerInput>();
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
        transform.position += moveDirection;
        if (moveDirection != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(moveDirection, Vector3.up);
        }
    }
}
