using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] float maxX;
    public GameObject[] Candies;
    [SerializeField] float spawnInterval;

    public static Spawner instance;
    void Start()
    {
        startSpawn();
    }

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void spawnCandy()
    {
        int randomSpawn = Random.Range(0, Candies.Length);
        float randomX = Random.Range(-maxX, maxX);
        Vector3 randomPos = new Vector3(randomX, transform.position.y, transform.position.z);
        Instantiate(Candies[randomSpawn], randomPos, transform.rotation);
    }

    IEnumerator SpawnCandies()
    {
        yield return new WaitForSeconds(2f);

        while (true)
        {
            spawnCandy();
            yield return new WaitForSeconds(spawnInterval);
        }
    }

    void startSpawn()
    {
        StartCoroutine(SpawnCandies());
    }

    public void stopSpawn()
    {
        StopAllCoroutines();
    }

}
