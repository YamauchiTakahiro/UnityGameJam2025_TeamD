using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossEnemy : MonoBehaviour
{
    private float speed = 5.0f;
    public bool flag;
    [SerializeField] private Renderer PlaerInvincible;
    public GameObject[] EnemyBarrage;
    public AudioClip sound;
    public int hitCount = 50;

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

        if (hitCount <= 20)

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
        }
    }
}

