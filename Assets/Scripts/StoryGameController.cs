using UnityEngine;

public class StoryGameController : MonoBehaviour
{
    public GameObject istructionsPanel;
    public GameObject rocks;
    public static bool gameReady = false;
    public static bool startedGame = false;
    public static bool reachedScore = false;
    float spawnTimer;
    float spawnRate = 1f;

    void Start()
    {
        Time.timeScale = 0;
        startedGame = false;
        gameReady = false;
        reachedScore = false;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !startedGame)
        {
            GetComponent<AudioSource>().Play();
            istructionsPanel.SetActive(false);
            Time.timeScale = 1;
            startedGame = true;
        }

        if(gameReady && !StoryGameController.reachedScore)
        {
            spawnTimer += Time.deltaTime;
            if (spawnTimer >= spawnRate)
            {
                spawnTimer -= spawnRate;
                Vector2 spawnPosition = new Vector2(Random.Range(-4.24f, 7.24f), Random.Range(-13.82f, -15.82f));
                Instantiate(rocks, spawnPosition, Quaternion.identity);
            }
        }
    }
}
