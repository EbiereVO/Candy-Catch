using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] float maxX;
    public GameObject[] Candies;
    void Start()
    {
        spawnCandy();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnCandy()
    {
        int randomSpawn = Random.Range(0, Candies.Length);
        float randomX = Random.Range(-maxX, maxX);
        Vector3 randomPos = new Vector3(randomX, transform.position.y, transform.position.z);
        Instantiate(Candies[randomSpawn], randomPos, transform.rotation);
    }
}
