using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class BarrageUpItem : MonoBehaviour
{
    public GameObject player;//player���擾���邽�߂̕ϐ�
    // Start is called before the first frame update
    //�����蔻�菈��
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
