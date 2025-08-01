using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutBarrage : MonoBehaviour
{
    [SerializeField] GameObject barrageprefab;
    private float speed = 300;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject barrage = (GameObject)Instantiate(barrageprefab, transform.position, Quaternion.identity);
            Rigidbody barrageRigidbody = barrage.GetComponent<Rigidbody>();
            barrageRigidbody.AddForce(transform.right * speed);
        }
    }
}
