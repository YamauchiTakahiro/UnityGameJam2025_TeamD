using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameClearScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetButtonDown("Decision"))
        //{
        //    SceneManager.LoadScene("TitleController");
        //}
    }

    public void onClickStartButton()
    {
        SceneManager.LoadScene("Title");
    }
}
