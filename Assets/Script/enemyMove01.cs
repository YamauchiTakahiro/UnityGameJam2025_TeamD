using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove01 : MonoBehaviour
{
    private float speed03 = 3.0f;
    private bool flag;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Update is called once per frame
    void Update()
    {
        if (transform.position.y >= 3)
            flag = true;
        else if (transform.position.y <= -3)
            flag = false;

        if (flag)
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(9, -3, 1), speed03 * Time.deltaTime);
        else if (!flag)
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(9, 3, 1), speed03 * Time.deltaTime);
    }

}
