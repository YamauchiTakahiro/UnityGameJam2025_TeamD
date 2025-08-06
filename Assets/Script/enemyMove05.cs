using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemyMove05 : MonoBehaviour
{
    private float speed = 5.0f;
    public bool flag;
    [SerializeField] GameObject item;
    public int random;
    public AudioClip sound;

    // Start is called before the first frame update
    void Start()
    {

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
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(4, -7, 1), speed * Time.deltaTime);
        }

        else if (!flag)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(4, 7, 1), speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerBarrage"))
        {
            random = Random.Range(1, 100);
            if (random <= 35)
            {
                if (item)
                {
                    Instantiate(item, transform.position, Quaternion.identity);
                }
            }
            Destroy(gameObject);
            AudioSource.PlayClipAtPoint(sound, transform.position);
        }
    }
}
