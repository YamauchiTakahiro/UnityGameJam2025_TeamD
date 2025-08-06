using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawnScript : MonoBehaviour
{
    [SerializeField] GameObject BossEnemy;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("BossEnemySpawn");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator BossEnemySpawn()
    {
        yield return new WaitForSeconds(40.0f);
        Instantiate(BossEnemy, transform.position, Quaternion.identity);
    }
}
