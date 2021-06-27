using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : Enemies
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward(8);
        DetectCollision();
        DestroyOutOfBords();
    }
}
