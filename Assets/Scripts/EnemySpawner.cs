using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    bool isSpawn = true;
    [SerializeField] GameObject enemy;
    [SerializeField] float timeBetweenSpawns = 5f;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    private IEnumerator SpawnEnemy()
    {        
        while(isSpawn)
        {
            Instantiate(enemy, new Vector2(9.5f, Random.Range(0, 5) + 0.5f), Quaternion.identity);            
            yield return new WaitForSeconds(Random.Range(1, timeBetweenSpawns));            
        }        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
