using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stations : MonoBehaviour
{

    [SerializeField] private Transform 

    void Start()
    {
        //d�clarer 
    }

    void Update()
    {
        //ramasser un objet
        void Pickup()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Physics.Raycast(transform.position);
            }
        }

        void Drop()
        {

        }

        //interagir avec la station si les conditions requises sont compl�t�es
        void InteractionStation()
        {

        }

        //interagir avec la station pour la remplir
        void RefillStation()
        {

        }

        //pour commander les ravitaillements et des pizzas
        void Calzone()
        {

        }
    }
}
