using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemCount : MonoBehaviour
{
    public int itemCount = 0;
    public TMP_Text itemCountText;
    // Start is called before the first frame update
    void Start()
    {
        itemCount = 0;
        itemCountText = GetComponent<TMP_Text>();
        itemCountText.text = "item:";
    }

    // Update is called once per frame
    void Update()
    {
        itemCountText.text = "item:" + itemCount.ToString();
    }
}
