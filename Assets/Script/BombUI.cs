using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BombUI : MonoBehaviour
{
    public int bomb = 0;
    private TMP_Text bombText;
    // Start is called before the first frame update
    void Start()
    {
        bomb = 0;
        bombText = GetComponent<TMP_Text>();
        bombText.text = "bomb:0";
    }

    // Update is called once per frame
    void Update()
    {
        bombText.text = "bomb:" + bomb.ToString();
    }
}
