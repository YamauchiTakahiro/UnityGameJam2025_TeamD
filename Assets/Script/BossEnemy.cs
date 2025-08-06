using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossEnemy : MonoBehaviour
{
    private float speed = 5.0f;
    public bool flag;
    public AudioClip sound;
    public int hitCount = 50;
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
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(9, -3, 1), speed * Time.deltaTime);
        }

        else if (!flag)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(9, 3, 1), speed * Time.deltaTime);
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
                AudioSource.PlayClipAtPoint(sound, transform.position);
            }
        }
    }
}

