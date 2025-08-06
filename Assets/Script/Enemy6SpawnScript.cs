using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy6SpawnScript : MonoBehaviour
{
    [SerializeField] GameObject Enemy;
    public GameObject EnemySpawn1;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("EnemySpawn");
        Invoke(nameof(EnemySpaneActive), 40.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator EnemySpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(6.0f);
            Instantiate(Enemy, transform.position, Quaternion.identity);
        }
    }

    void EnemySpaneActive()
    {
        EnemySpawn1.SetActive(false);
    }
}