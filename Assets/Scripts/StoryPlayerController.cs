using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoryPlayerController : MonoBehaviour
{
    public GameObject cinemachineCamera;
    public GameObject gameoverPanel;
    public GameObject scorePanel;
    public GameObject commandsPanel;
    public Text gameoverScoreText;
    void Update()
    {
        if(Time.timeScale == 0)
        {
            StoryGameController.gameReady = false;
        }

        if(!StoryGameController.gameReady)
        {
            if (transform.position.y > -17.77f)
            {
                transform.position = new Vector2(transform.position.x,
                transform.position.y - 3f * Time.deltaTime);
            }
            else
            {
                cinemachineCamera.SetActive(false);
                StoryGameController.gameReady = true;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "obstacle")
        {
            Time.timeScale = 0;
            scorePanel.SetActive(false);
            commandsPanel.SetActive(false);
            gameoverScoreText.text = StoryScore.score.ToString();
            gameoverPanel.SetActive(true);
        }
    }
}
