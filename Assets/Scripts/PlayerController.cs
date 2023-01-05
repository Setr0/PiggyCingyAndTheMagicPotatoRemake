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
    public GameObject scorePanel;
    public Text gameOverScoreText;

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
        if (Input.GetMouseButtonDown(0) && transform.position.y < -2.2f)
        {
            rb.velocity = new Vector2(0f, 13f);
            jumpAudioSource.Play();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "obstacle")
        {
            backgroundAudioSource.Stop();
            gameOverAudioSource.Play();
            Time.timeScale = 0;
            scorePanel.SetActive(false);
            gameOverPanel.SetActive(true);
            gameOverScoreText.text = score.scoreNumber.ToString();
        }
    }
}
