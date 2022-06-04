using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public static int score = 1000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        if (PlayerPrefs.HasKey("highscore"))
            score = PlayerPrefs.GetInt("highscore");
        PlayerPrefs.SetInt("HighScore", score);
    }

    // Update is called once per frame
    void Update()
    {
        //PlayerPrefs.SetInt("HighScore", 100);
        Text gt = GameObject.Find("HighScore").GetComponent<Text>();
        gt.text = "High Score: " + score;
        if(score > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
}
