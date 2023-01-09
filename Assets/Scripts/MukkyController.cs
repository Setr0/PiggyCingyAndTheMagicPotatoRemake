using UnityEngine;

public class MukkyController : MonoBehaviour
{
    Vector2 startPosition;
    AudioSource audioSource;
    void Start()
    {
        startPosition = transform.position;
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(transform.position.x >= -22.34f)
        {
            transform.position = new Vector2(transform.position.x - 6f * Time.deltaTime,
            startPosition.y);
        }
        else
        {
            transform.position = startPosition;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            audioSource.Play();
        }
    }
}
