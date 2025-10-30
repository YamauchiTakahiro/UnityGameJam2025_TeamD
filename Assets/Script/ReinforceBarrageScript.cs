using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ReinforceBarrage : MonoBehaviour
{
    [SerializeField] GameObject sphere;
    private float timeReset = 1;
    private float time = 0;
    private float speed = 300;
    public AudioClip sound;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time > timeReset)
        {
            if (Input.GetButton("Fire1"))
            {
                GameObject ball = (GameObject)Instantiate(sphere, transform.position, Quaternion.identity);
                Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();
                ballRigidbody.AddForce(transform.right * speed);
                AudioSource.PlayClipAtPoint(sound, transform.position);
                time = 0;
            }
            else if (Input.GetKey(KeyCode.Space))
            {
                GameObject ball = (GameObject)Instantiate(sphere, transform.position, Quaternion.identity);
                Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();
                ballRigidbody.AddForce(transform.right * speed);
                AudioSource.PlayClipAtPoint(sound, transform.position);
                time = 0;
            }
        }
    }
}
