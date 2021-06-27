using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalspawn;
    private float spawnXRange = 10;
    private float spawnZ = 20;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2, 1);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnRandomAnimal()
    {
        int spawnNum = Random.Range(0, animalspawn.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnXRange, -spawnXRange), 0, spawnZ);
        Instantiate(animalspawn[spawnNum], spawnPos, animalspawn[spawnNum].transform.rotation);
    }
}
