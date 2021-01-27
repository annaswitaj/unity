using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    float randX;
    Vector3 whereToSpawn;
    public float spawnRate = 1f;
    float nextSpawn = 0f;
    
   

    // Update is called once per frame
    void Update()
    {
        
        if (Time.time>nextSpawn)
        {
           
            nextSpawn = Time.time +spawnRate;
            randX = Random.Range(0f, 30f);
            whereToSpawn = new Vector3(randX, transform.position.y, 0);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
        }
    }
}
