using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropsParticleSystem : MonoBehaviour
{
    public ParticleSystem particules;

    // Start is called before the first frame update
    void Start()
    {
        particules.Stop();
    }

    void OnTriggerEnter(Collider other)
    {

        particules.Play();

    }

    void OnTriggerExit(Collider other)
    {

        particules.Stop();

    }
}
