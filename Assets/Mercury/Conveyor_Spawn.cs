using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conveyor_Spawn : MonoBehaviour
{
    [Header ("Spawnable list")]
    private bool IsCoroutineRunning = false;
    public Transform[] prefab;
    [Header("Spawn Object")]
    public float sec;
    public Transform StartObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsCoroutineRunning )
        {
         StartCoroutine("SpawnObject");
        }
    }

    IEnumerator SpawnObject()
    {
        IsCoroutineRunning = true;
        foreach (Transform t in prefab)
        {
            Instantiate(t, StartObject.position, Quaternion.identity);
            yield return new WaitForSeconds(sec);
        }
        IsCoroutineRunning=false;
        yield return null;
    }
}
