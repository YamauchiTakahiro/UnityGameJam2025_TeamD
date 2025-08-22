using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrageScript : MonoBehaviour
{
    [SerializeField] GameObject sphere;
    private float timeReset = 1;
    private float time = 0;
    private float speed = 300;
    public AudioClip sound;
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //一定間隔で実行する
        time += Time.deltaTime;
        if(time > timeReset)
        {
            //spaceキー長押しで実行する
            if (Input.GetKey("space"))
            {
                //弾を出す
                GameObject barrage = (GameObject)Instantiate(sphere, transform.position, Quaternion.identity);
                Rigidbody barrageRigidbody = barrage.GetComponent<Rigidbody>();
                barrageRigidbody.AddForce(transform.right * speed);
                AudioSource.PlayClipAtPoint(sound, transform.position);
                time = 0;
            }
            
        }
    }
}
