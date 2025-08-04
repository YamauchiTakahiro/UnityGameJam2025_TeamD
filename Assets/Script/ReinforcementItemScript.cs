using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReinforcementItemScript : MonoBehaviour
{
    public GameObject ItemObject;
    [SerializeField]
    private Item item;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //アイテムドロップ
    public void ItemDrop()
    {
        if(item.GetItemName() == "ReinforcementItem")
        {
            Instantiate(ItemObject, transform.position, Quaternion.identity);
        }
    }

}
