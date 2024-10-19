using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    MeshRenderer renderer;
    Rigidbody rigidbody;
    [SerializeField] float timeTowait = 5f;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();

        
      
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > timeTowait)
        {
            renderer.enabled = true;
            rigidbody.useGravity = true;
        }
       
    }
}
