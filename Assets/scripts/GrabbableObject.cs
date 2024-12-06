using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableObject : MonoBehaviour
{
    private Rigidbody body;
    private Transform ObjectGrabPositionTransform;
    private ParticleSystem particle;
    private bool Grabbed;


    float lerpSpeed = 10f;


    private void Awake()
    {
        body = GetComponent<Rigidbody>();
        particle = GetComponent<ParticleSystem>();
        Grabbed = false;
    }
    public void Grab(Transform ObjectGrabPositionTransform)
    {
        this.ObjectGrabPositionTransform = ObjectGrabPositionTransform;
        body.useGravity = false;
        Grabbed = true;
    }

    public void Drop()
    {
        this.ObjectGrabPositionTransform = null;
        body.useGravity = true;
        Grabbed = false;
    }

    private void FixedUpdate()
    {
        if (Grabbed == true)
        {
            particle.Stop();
        }
        

        if (ObjectGrabPositionTransform != null)
        {
            Vector3 newPosition = Vector3.Lerp(transform.position, ObjectGrabPositionTransform.position, Time.deltaTime * lerpSpeed);
            body.MovePosition(newPosition);
        }
    }
}