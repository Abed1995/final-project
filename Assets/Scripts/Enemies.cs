using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{

    float bottomBound = -10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.z < bottomBound)
        {
            Debug.Log("GAME OVER");
            Destroy(gameObject);
        }
    }

    public void MoveForward(int speed)
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    public void DetectCollision()
    {
        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Pizza"))
            {
                Destroy(other.gameObject);
                Destroy(gameObject);
            }

        }
    }

    public void DestroyOutOfBords()
    {
        if (transform.position.z < bottomBound)
        {
            Debug.Log("GAME OVER");
            Destroy(gameObject);
        }
    }
}
