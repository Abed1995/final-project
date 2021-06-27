﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    float timer;

    private void Start()
    {
        timer = 1;
    }

    // Update is called once per frame
    void Update()
    {
       
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && timer ==1 )
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            timer = 0;
           
        }
        timer = timer + Time.deltaTime;
        if (timer > 1)
            timer = 1;

    }
   
}
