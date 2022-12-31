using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Spawner : MonoBehaviour
{
    [SerializeField] float start = 0.0f;
    [SerializeField] float repete = 1.0f;
    public GameObject[] myObjects;

    void Start()
    {
        InvokeRepeating("SpawnEnemy", start, repete);
    }

    void SpawnEnemy()
    {
        int randomIndex = Random.Range(0, myObjects.Length);
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-30, 30), Random.Range(5, 25), Random.Range(30, 50));
        Instantiate(myObjects[randomIndex], randomSpawnPosition, myObjects[randomIndex].transform.rotation);
    }
}


