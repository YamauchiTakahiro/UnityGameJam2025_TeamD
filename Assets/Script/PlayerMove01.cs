using System.Collections;

using System.Collections.Generic;

using UnityEngine;

public class PlayerMove02 : MonoBehaviour

{

    public float speed = 5.0f;

    public int ReinforcementItemCount = 0;

    public GameObject[] ReinforceBarrage;

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

        }

        if (other.gameObject.CompareTag("EnemyBarrage"))

        {

            Destroy(gameObject);

        }

    }

}

