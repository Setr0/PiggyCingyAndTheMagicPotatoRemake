using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public Sprite[] spriteArray;
    public RuntimeAnimatorController[] animatorControllerArray;
    public SpriteRenderer spriteRender;
    public AudioSource backgroundAudioSource;
    public AudioSource jumpAudioSource;
    public AudioSource gameOverAudioSource;
    public Animator animator;
    public GameObject gameController;
    public GameObject gameOverPanel;
    public GameObject doubleJumpPanel;
    public GameObject scorePanel;
    public Text doubleJumpText;
    public Text gameOverScoreText;
    bool doubleJump = true;
    float doubleJumpTimer = 0f;

    private void Start()
    {
        backgroundAudioSource = gameController.GetComponent<AudioSource>();
        if(chooseCharacter.character == "piggy")
        {
            spriteRender.sprite = spriteArray[0];
            animator.runtimeAnimatorController = animatorControllerArray[0];
        }
        else if(chooseCharacter.character == "cingy")
        {
            spriteRender.sprite = spriteArray[1];
            animator.runtimeAnimatorController = animatorControllerArray[1];
        }
        else
        {
            SceneManager.LoadScene(1);
        }
    }

    void Update()
    {
        if(!doubleJump)
        {
            doubleJumpTimer += Time.deltaTime;
        }
        
        if (Input.GetMouseButtonDown(0) && transform.position.y < -2.2f)
        {
            rb.velocity = new Vector2(0f, 13f);
            jumpAudioSource.Play();
        }

        else if (Input.GetMouseButtonDown(0) && transform.position.y > -2.2f && doubleJump)
        {
            rb.velocity = new Vector2(0f, 13f);
            jumpAudioSource.Play();
            doubleJump = false;
        }

        else if(transform.position.y < -2.2f && doubleJumpTimer >= 3f)
        {
            doubleJump = true;
            doubleJumpTimer = 0f;
        }

        doubleJumpText.text = $"Double Jump: {doubleJump}";
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "obstacle")
        {
            backgroundAudioSource.Stop();
            gameOverAudioSource.Play();

            Time.timeScale = 0;

            doubleJumpPanel.SetActive(false);
            scorePanel.SetActive(false);
            gameOverPanel.SetActive(true);

            gameOverScoreText.text = Score.scoreNumber.ToString();
        }
    }
}
