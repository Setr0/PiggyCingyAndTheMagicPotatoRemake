using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryScore : MonoBehaviour
{
    Text scoreText;
    int score;
    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    void Update()
    {
        if (StoryGameController.gameReady)
        {
            score++;
            scoreText.text = score.ToString();
        }
        
    }
}
