using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    bool isSpawn = true;
    [SerializeField] GameObject[] Enemies;
    [SerializeField] float timeBetweenSpawns = 5f;
    Coroutine spawnEnemy;
    // Start is called before the first frame update
    void Start()
    {
        spawnEnemy =  StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {        
        while(isSpawn)
        {
            float yCoOrdinate = Random.Range(0, 5);
            GameObject enemyToBeSpawned = Enemies[Random.Range(0, Enemies.Length)];
            if (enemyToBeSpawned.name == "Lizard")
            {
                yCoOrdinate += 0.5f;
            }
            // Attaching the following spawned enemy as a child of the enemySpawner so that the hierarchy remains clean and tidy
            GameObject spawedEnemy = Instantiate(enemyToBeSpawned, new Vector2(9.5f, yCoOrdinate), Quaternion.identity);
            spawedEnemy.transform.parent = transform;
            yield return new WaitForSeconds(Random.Range(1, timeBetweenSpawns));            
        }        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StopEnemySpawning()
    {
        StopCoroutine(spawnEnemy);
    }

}
