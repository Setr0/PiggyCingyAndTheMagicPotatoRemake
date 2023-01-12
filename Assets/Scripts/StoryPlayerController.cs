using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StoryPlayerController : MonoBehaviour
{
    public GameObject cinemachineCamera;
    public GameObject gameoverPanel;
    public GameObject scorePanel;
    public GameObject commandsPanel;
    public SpriteRenderer spriteRender;
    public Animator animator;
    public Sprite[] spriteArray;
    public RuntimeAnimatorController[] animatorControllerArray;
    public AudioSource backgroundSound;
    public AudioSource gameoverSound;
    public Text gameoverScoreText;

    void Start()
    {
        if(ChooseCharacter.character == "piggy")
        {
            spriteRender.sprite = spriteArray[0];
            animator.runtimeAnimatorController = animatorControllerArray[0];
        }

        else if(ChooseCharacter.character == "cingy")
        {
            spriteRender.sprite = spriteArray[1];
            animator.runtimeAnimatorController = animatorControllerArray[1];
        }

        else
        {
            SceneManager.LoadScene(3);
        }
    }

    void Update()
    {
        if(Time.timeScale == 0)
        {
            StoryGameController.gameReady = false;
        }

        if(StoryGameController.startedGame && !StoryGameController.gameReady)
        {
            if (transform.position.y > -10.34f)
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
            gameoverSound.Play();
            backgroundSound.Stop();
            Time.timeScale = 0;
            scorePanel.SetActive(false);
            commandsPanel.SetActive(false);
            gameoverScoreText.text = StoryScore.score.ToString();
            gameoverPanel.SetActive(true);
        }
    }
}
