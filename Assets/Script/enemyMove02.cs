using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.IO.LowLevel.Unsafe.AsyncReadManagerMetrics;

public class enemyMove02 : MonoBehaviour
{
    private float speed = 5.0f;
    public bool flag;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (flag)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(8, 3, 1), speed * Time.deltaTime);
        }

        else if (!flag)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(8, -3, 1), speed * Time.deltaTime);
        }

        if (Input.GetMouseButtonDown(0))
        {
            flag = true;
        }

        else if (Input.GetMouseButtonDown(1))
        {
            flag = false;
        }
    }
}
