using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBords : MonoBehaviour
{
    float topBound = 40f;
    float bottomBound = -10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < bottomBound)
        {
            Debug.Log("GAME OVER");
            Destroy(gameObject);
        }
    }
}
