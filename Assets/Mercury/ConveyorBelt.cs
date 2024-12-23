using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public List<GameObject> OnBelt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i <= OnBelt.Count - 1; i++)
        {
            
            OnBelt[i].GetComponent<Rigidbody>().velocity = speed * direction * Time.deltaTime; 
        }
    }

    void OnTriggerEnter(Collider other)
    {
        //collision.GetComponent<Rigidbody>().useGravity = false;
        OnBelt.Add(other.gameObject);
        
    }
    void OnTriggerExit(Collider other)
    {
        //collision.GetComponent<Rigidbody>().useGravity=true;
        OnBelt.Remove(other.gameObject);
    }
}