using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    //bonus animal
    public GameObject bonusAnimal;
    private float spawnRangeX = 20, spawnPosZ = 20;
    private float startDelay = 2, interval = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, interval);
    }

    // Update is called once per frame
    void Update()
    {
        //spawn bonus animal when 'S' key is pressed
        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(bonusAnimal, new Vector3(Random.Range(-spawnRangeX, spawnRangeX),0,spawnPosZ), bonusAnimal.transform.rotation);
        }
    }

    void SpawnRandomAnimal()
    {
        //randomly spawn animals
        int index = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        Instantiate(animalPrefabs[index], spawnPos, animalPrefabs[index].transform.rotation);
    }
}
