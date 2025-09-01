using System.Collections;

using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class PlayerMove02 : MonoBehaviour

{

    public float speed = 5.0f;

    public int ReinforcementItemCount = 0;
    [SerializeField] private Renderer PlaerInvincible;
    public GameObject[] ReinforceBarrage;
    public GameObject[] Barrage;
    public GameObject[] BombBarrage;
    public GameObject enemyBarrage;

    public CollectionBase Player;
    public AudioClip sound;

    public AudioClip ItemSound;
    public AudioClip LifeItemSound;
    public AudioClip BombItemSound;
    public int hitCount = 3;
    public int bombCount = 0;
    public bool isHit;

    private GameObject scoreText;
    private GameObject lifeText;
    private GameObject bombText;
    private GameObject itemCountText;
    // Start is called before the first frame update

    void Start()

    {
        scoreText = GameObject.Find("Score");
        lifeText = GameObject.Find("Life");
        bombText = GameObject.Find("Bomb");
        itemCountText = GameObject.Find("ItemCount");
    }

    // Update is called once per frame

    void Update()

    {

        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;

        float moveY = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.position = new Vector3(transform.position.x + moveX, transform.position.y + moveY, transform.position.z);

        if (transform.position.y < -4)
        {
            transform.position = new Vector3(transform.position.x, -4.0f, transform.position.z);
        }

        if (transform.position.y > 7)
        {
            transform.position = new Vector3(transform.position.x, 7.0f, transform.position.z);
        }

        if (transform.position.x < -10)
        {
            transform.position = new Vector3(-10.0f, transform.position.y, transform.position.z);
        }

        if (transform.position.x > 1)
        {
            transform.position = new Vector3(0.0f, transform.position.y, transform.position.z);

        }

        if (ReinforcementItemCount >= 1)
        {

            ReinforceBarrage[0].SetActive(true);

            ReinforceBarrage[1].SetActive(true);

        }
                
        if(bombCount >= 1)
        {
            if (Input.GetKeyDown("b"))
            {
                BombBarrage[0].SetActive(true);
                bombCount--;
                bombText.GetComponent<BombUI>().bomb--;
                Invoke(nameof(Bomb), 2.0f);
            }
        }
        else if (bombCount == 0 && ReinforcementItemCount >= 5)
        {
            if (Input.GetKeyDown("b"))
            {
                BombBarrage[0].SetActive(true);
                ReinforcementItemCount -= 5;
                itemCountText.GetComponent<ItemCount>().itemCount -= 5;
                Invoke(nameof(Bomb), 2.0f);
            }
        }
    }
    private void OnTriggerEnter(Collider other)

    {

        if (other.gameObject.CompareTag("ReinforcementItem"))

        {
            Destroy(other.gameObject);

            ReinforcementItemCount += 1;

            AudioSource.PlayClipAtPoint(ItemSound, transform.position);
            scoreText.GetComponent<Score>().score += 100;
            itemCountText.GetComponent<ItemCount>().itemCount++;

        }

        if(other.gameObject.CompareTag("LifeItem"))
        {
            Destroy(other.gameObject);

            hitCount += 1;

            AudioSource.PlayClipAtPoint(LifeItemSound, transform.position);
            lifeText.GetComponent<Life>().life++;
        }

        if (other.gameObject.CompareTag("BombItem"))
        {
            Destroy(other.gameObject);

            bombCount += 1;

            AudioSource.PlayClipAtPoint(BombItemSound, transform.position);
            bombText.GetComponent<BombUI>().bomb++;
        }

        if (other.gameObject.CompareTag("EnemyBarrage"))
        {
            hitCount -= 1;
            AudioSource.PlayClipAtPoint(sound, transform.position);
            this.gameObject.layer = 10;
            Invoke(nameof(PlayerActive), 1.0f);
            scoreText.GetComponent<Score>().score -= 100;
            lifeText.GetComponent<Life>().life--;
            if (hitCount == 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("GameOver");
            }
        }
        
    }

    void PlayerActive()
    {
        this.gameObject.layer = 8;
    }

    void Bomb()
    {
        BombBarrage[0].SetActive(false);
    }
}

