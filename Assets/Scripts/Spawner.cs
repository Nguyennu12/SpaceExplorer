using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Obstacle; 
    public float maxY;
    public float minY;
    public float TimeBetweenSpawn;
    private float SpawnTime;

    void Update()
    {
        if (Time.time > SpawnTime)
        {
            Spawn();
            SpawnTime = Time.time + TimeBetweenSpawn;
        }
    }

   
    void Spawn()
    {

        float randomY = Random.Range(minY, maxY);

     
        Vector3 spawnPosition = new Vector3(transform.position.x, randomY, transform.position.z);

      
        Instantiate(Obstacle, spawnPosition, transform.rotation);
    }
}