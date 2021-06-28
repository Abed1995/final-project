using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Enemies
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward(3);
      
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
