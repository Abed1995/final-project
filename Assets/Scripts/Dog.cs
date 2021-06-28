using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Enemies //inheritance 
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        // POLYMORPHISM
        MoveForward(6);

        //abstraction
        DestroyOutOfBords();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pizza"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }

    }
}
