using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Station : MonoBehaviour
{
    public float action = 3.5f;
    public GameObject grabbed = null;


    private void Interaction(Collider other)
    {
        if (other.tag == "RedPaint Station" && grabbed.tag == "Unpainted Toy") // && bool objet tenu + bool objet non paint
        {
            Debug.Log("Station de peinture");
            if(Input.GetKeyDown("E"))
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

        if(other.tag == "Sleigh" && grabbed.tag == "Gift")
        {
            Debug.Log("Traîneaux export");
            if(Input.GetKeyDown("E"))
            {
                Destroy(grabbed.tag);
                //Score système
            }
        }

        if(other.tag == "Sewing Station")
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

        if(other.tag == "Carpentry" && grabbed.tag == "Wood")
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

        if(other.tag == "Electronic Station" && grabbed.tag == "Eletric Toy")
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
