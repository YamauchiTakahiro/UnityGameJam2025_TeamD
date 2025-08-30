using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreReslut : MonoBehaviour
{
    public int resultScore = 0;
    private TMP_Text ResultScoreText;
    // Start is called before the first frame update
    void Start()
    {
        resultScore = 0;
        ResultScoreText = GetComponent<TMP_Text>();
        ResultScoreText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        ResultScoreText.text = "" + resultScore.ToString();
    }
}
