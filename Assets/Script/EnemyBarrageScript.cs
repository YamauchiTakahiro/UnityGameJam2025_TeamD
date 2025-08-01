using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBarrageScript : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
            InvokeRepeating("EnemyBarrageSpawn", 1.0f, 1.0f);
    }

    void Update()
    {
        
    }

    void EnemyBarrageSpawn()
    {
        if(transform.position.x <= 10.0f && transform.position.x >= -10.0f)
        {
            GameObject enemyBarrage = GameObject.Instantiate(prefab) as GameObject;
            enemyBarrage.GetComponent<Rigidbody>().AddForce(transform.right * -300);
        }
    }
}
