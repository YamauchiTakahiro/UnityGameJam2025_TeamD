using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Life : MonoBehaviour
{
    public int life = 3; 
    private TMP_Text lifeText;
    // Start is called before the first frame update
    void Start()
    {
        life = 3;
        lifeText = GetComponent<TMP_Text>();
        lifeText.text = "life:3";
    }

    // Update is called once per frame
    void Update()
    {
        lifeText.text = "life:" + life.ToString();
    }
}