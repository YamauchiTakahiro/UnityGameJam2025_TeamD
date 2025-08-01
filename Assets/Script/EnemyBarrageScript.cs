using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBarrageScript : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
            InvokeRepeating("EnemyBarrageSpawn", 1.0f, 0.5f);
    }

    void Update()
    {
        
    }

    void EnemyBarrageSpawn()
    {
        GameObject enemyBarrage = GameObject.Instantiate(prefab) as GameObject;
        enemyBarrage.GetComponent<Rigidbody>().AddForce(transform.right * -300);
    }
}
