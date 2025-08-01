using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class BarrageUpItem : MonoBehaviour
{
    public GameObject player;//player‚ğæ“¾‚·‚é‚½‚ß‚Ì•Ï”
    // Start is called before the first frame update
    //“–‚½‚è”»’èˆ—
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
        {
            
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
