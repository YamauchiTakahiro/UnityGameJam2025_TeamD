using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1SpawnScript : MonoBehaviour
{
    [SerializeField] GameObject Enemy;
    public GameObject EnemySpawn1;
    public int spawnTimeRandom;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("EnemySpawn");
        Invoke(nameof(EnemySpaneActive), 100.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator EnemySpawn()
    {
        while (true)
        {
            spawnTimeRandom = Random.Range(1, 10);
            yield return new WaitForSeconds(spawnTimeRandom);
            Instantiate(Enemy, transform.position, Quaternion.identity);
        }
    }

    void EnemySpaneActive()
    {
        EnemySpawn1.SetActive(false);
    }
}