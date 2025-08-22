using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEditor.Progress;

public class BossEnemy : MonoBehaviour
{
    private float speed = 5.0f;
    public bool flag;
    [SerializeField] private Renderer PlaerInvincible;
    [SerializeField] GameObject item;
    [SerializeField] GameObject lifeitem;
    [SerializeField] GameObject bombitem;
    public GameObject[] EnemyBarrage;
    public AudioClip sound;
    public int hitCount = 500;
    public bool itemFlag = false;
    public int random;

    private GameObject scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= 3)
        {
            flag = true;
        }

        else if (transform.position.y <= -3)
        {
            flag = false;
        }

        if (flag)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(9, -3, 1), speed * Time.deltaTime);
        }

        else if (!flag)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(9, 3, 1), speed * Time.deltaTime);
        }

        if (hitCount <= 200)

        {

            EnemyBarrage[0].SetActive(true);

            EnemyBarrage[1].SetActive(true);

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerBarrage"))
        {
            hitCount -= 1;
            if(hitCount == 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("GameClear");
                AudioSource.PlayClipAtPoint(sound, transform.position);
                scoreText.GetComponent<Score>().score += 10000;
            }
            if(hitCount <= 300 && itemFlag == false)
            {
                random = UnityEngine.Random.Range(1, 3);
                if (random == 1)
                {
                    if (item)
                    {
                        Instantiate(item, transform.position, Quaternion.identity);
                        itemFlag = true;
                    }
                }

                if (random == 2)
                {
                    if (lifeitem)
                    {
                        Instantiate(lifeitem, transform.position, Quaternion.identity);
                        itemFlag = true;
                    }
                }

                if (random == 3)
                {
                    if (bombitem)
                    {
                        Instantiate(bombitem, transform.position, Quaternion.identity);
                        itemFlag = true;
                    }
                }
            }
        }

        if(other.gameObject.CompareTag("BombBarrage"))
        {
            hitCount -= 10;
            if (hitCount <= 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("GameClear");
                AudioSource.PlayClipAtPoint(sound, transform.position);
                scoreText.GetComponent<Score>().score += 10000;
            }
        }
    }
}

