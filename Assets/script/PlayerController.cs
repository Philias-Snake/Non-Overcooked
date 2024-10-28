using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using Mirror;

public class PlayerController : NetworkBehaviour
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
        //si pas client ne pas tourner cette methode
        if (!isLocalPlayer)
        {
            return;
        }
        MovePlayer();
    }

    void MovePlayer()
    {
        Vector2 direction = moveAction.ReadValue<Vector2>();
        transform.position += new Vector3(direction.x, 0, direction.y) * moveSpeed * Time.deltaTime;
    }
}
