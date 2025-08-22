using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemyMove04 : MonoBehaviour
{
    private float speed = 5.0f;
    public bool flag;
    [SerializeField] GameObject item;
    [SerializeField] GameObject lifeitem;
    [SerializeField] GameObject bombitem;
    public int random;
    public AudioClip sound;

    private GameObject scoreText;

    // Start is called before the first frame update
    void Start()
    {
        //40秒後からEnemyがでないようにする
        Invoke(nameof(EnemyDestroy), 40.0f);
        scoreText = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        //y座標7以上の時フラグをtrueにする
        if (transform.position.y >= 7)
        {
            flag = true;
        }
        //y座標が‐7以下の時フラグをfalseにする
        else if (transform.position.y <= -7)
        {
            flag = false;
        }
        //フラグがtrueの時に下に移動する
        if (flag)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(6, -7, 1), speed * Time.deltaTime);
        }
        //フラグがfalseの時に上に移動する
        else if (!flag)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(6, 7, 1), speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("PlayerBarrage"))
        {
            random = Random.Range(1, 100);
            if (random <= 10)
            {
                if (item)
                {
                    Instantiate(item, transform.position, Quaternion.identity);
                }
            }
            if (random >= 11 && random <= 13)
            {
                if (lifeitem)
                {
                    Instantiate(lifeitem, transform.position, Quaternion.identity);
                }
            }
            if (random >= 14 && random <= 15)
            {
                if (bombitem)
                {
                    Instantiate(bombitem, transform.position, Quaternion.identity);
                }
            }
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(sound, transform.position);
            scoreText.GetComponent<Score>().score += 100;
        }

        if (other.gameObject.CompareTag("BombBarrage"))
        {
            random = Random.Range(1, 100);
            if (random <= 10)
            {
                if (item)
                {
                    Instantiate(item, transform.position, Quaternion.identity);
                }
            }

            if (random >= 11 && random <= 13)
            {
                if (lifeitem)
                {
                    Instantiate(lifeitem, transform.position, Quaternion.identity);
                }
            }

            if (random >= 14 && random <= 15)
            {
                if (bombitem)
                {
                    Instantiate(bombitem, transform.position, Quaternion.identity);
                }
            }
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(sound, transform.position);
            scoreText.GetComponent<Score>().score += 100;
        }
    }

    void EnemyDestroy()
    {
        Destroy(gameObject);
    }
}
