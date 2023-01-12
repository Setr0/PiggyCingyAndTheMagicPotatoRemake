using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryScore : MonoBehaviour
{
    Text scoreText;
    public static int score;
    void Start()
    {
        scoreText = GetComponent<Text>();
        score = 0;
    }

    void Update()
    {
        if (StoryGameController.gameReady && Time.timeScale != 0)
        {
            score++;
            scoreText.text = score.ToString();
        }
        
    }
}
