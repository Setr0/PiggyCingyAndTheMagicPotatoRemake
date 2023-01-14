using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StoryPlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject cinemachineCamera;
    public GameObject gameoverPanel;
    public GameObject scorePanel;
    public GameObject commandsPanel;
    public GameObject victoryPanel;
    public SpriteRenderer spriteRender;
    public Animator animator;
    public Sprite[] spriteArray;
    public RuntimeAnimatorController[] animatorControllerArray;
    public AudioSource backgroundSound;
    public AudioSource gameoverSound;
    public Text gameoverScoreText;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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

        if(StoryGameController.startedGame && !StoryGameController.gameReady && !StoryGameController.reachedScore)
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

        if(StoryScore.score >= 10000)
        {
            StoryGameController.reachedScore = true;
        }

        if (StoryGameController.reachedScore)
        {
            cinemachineCamera.SetActive(true);
            if (transform.position.y > -23.75f && cinemachineCamera.transform.position.y >= -23.75f)
            {
                transform.position = new Vector2(0f,
                transform.position.y - 3f * Time.deltaTime);
            }
            else
            {
                cinemachineCamera.SetActive(false);
                rb.gravityScale = 3.0f;
            }
        }

        #if UNITY_EDITOR
            rb.velocity = new Vector2(Input.GetAxis("Horizontal") * 6f, rb.velocity.y);
        #endif
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

        if (collision.gameObject.tag == "cup")
        {
            Time.timeScale = 0;
            victoryPanel.SetActive(true);
        }
    }
}
