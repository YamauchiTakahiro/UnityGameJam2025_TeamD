using System.Collections;

using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove02 : MonoBehaviour

{

    public float speed = 5.0f;

    public int ReinforcementItemCount = 0;
    [SerializeField] private Renderer PlaerInvincible;
    public GameObject[] ReinforceBarrage;
    public CollectionBase Player;
    public AudioClip sound;

    public AudioClip ItemSound;
    public int hitCount = 3;
    public bool isHit;
    // Start is called before the first frame update

    void Start()

    {
    }

    // Update is called once per frame

    void Update()

    {

        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;

        float moveY = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        transform.position = new Vector3(transform.position.x + moveX, transform.position.y + moveY, transform.position.z);

        if (ReinforcementItemCount >= 1)

        {

            ReinforceBarrage[0].SetActive(true);

            ReinforceBarrage[1].SetActive(true);

        }
    }

    private void OnTriggerEnter(Collider other)

    {

        if (other.gameObject.CompareTag("ReinforcementItem"))

        {

            Destroy(other.gameObject);

            ReinforcementItemCount += 1;

            AudioSource.PlayClipAtPoint(ItemSound, transform.position);

        }

        if (other.gameObject.CompareTag("EnemyBarrage"))
        {
            hitCount -= 1;
            AudioSource.PlayClipAtPoint(sound, transform.position);
            this.gameObject.layer = 10;
            Invoke(nameof(PlayerActive), 1.0f);
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
}

