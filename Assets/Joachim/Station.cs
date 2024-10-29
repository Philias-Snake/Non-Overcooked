using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Station : MonoBehaviour
{
    public float action = 3.5f;
    public GameObject test = null;

    public void Start()
    {
        test.tag = "Unpainted Toy";
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "RedPaint Station") // && bool objet tenu + bool objet non paint
        {
            Debug.Log("Station de peinture");
            if(Input.GetKeyDown("E"))
            {
                //animation
                if (Input.GetKeyDown("E") && Time.time > action)
                {
                    test.tag = "Painted Toy";
                    //sprite de l'objet change
                }
            }

        }

        if (other.tag == "BluePaint Station") // && bool objet tenu + bool objet non paint
        {
            Debug.Log("Station de peinture");
            if (Input.GetKeyDown("E"))
            {
                //animation
                if (Input.GetKeyDown("E") && Time.time > action)
                {
                    test.tag = "Painted Toy";
                    //sprite de l'objet change
                }
            }

        }

        if (other.tag == "GreenPaint Station") // && bool objet tenu + bool objet non paint
        {
            Debug.Log("Station de peinture");
            if (Input.GetKeyDown("E"))
            {
                //animation
                if (Input.GetKeyDown("E") && Time.time > action)
                {
                    test.tag = "Painted Toy";
                    //sprite de l'objet change
                }
            }

        }

        if (other.tag == "Packaging Station" && test.tag == "Painted Toy")
        {
            Debug.Log("Station d'emballage");
            if (Input.GetKeyDown("E"))
            {
                //animation
                if (Input.GetKeyDown("E") && Time.time > action)
                {
                    test.tag = "Gift";
                    //sprite de l'objet change
                }
            }
        }

        if(other.tag == "")
        {

        }
    }
}
