using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove01 : MonoBehaviour
{
    private float speed = 5.0f;
    public bool flag;
    private ReinforcementItemScript item;

    // Start is called before the first frame update
    void Start()
    {
        item = GetComponent<ReinforcementItemScript>();
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
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(9, 3, 1), speed * Time.deltaTime);
        }

        else if(!flag)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(9, -3, 1), speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PlayerBarrage"))
        { 
            if(item)
            {
                Instantiate(item, transform.position, Quaternion.identity);
            }
        }
    }
}
