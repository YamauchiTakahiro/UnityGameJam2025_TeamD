using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBarrageScript : MonoBehaviour
{
    [SerializeField] GameObject sphere;
    private float timeReset = 1;
    private float time = 0;
    private float speed = -300;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //ˆê’èŠÔŠu‚ÅÀs‚·‚é
        time += Time.deltaTime;
        if (time > timeReset)
        {
            //’e‚ğo‚·
            GameObject barrage = (GameObject)Instantiate(sphere, transform.position, Quaternion.identity);
            Rigidbody barrageRigidbody = barrage.GetComponent<Rigidbody>();
            barrageRigidbody.AddForce(transform.right * speed);
            time = 0;
        }
    }
}
