using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject potato;
    public GameObject istructionsPanel;
    public AudioSource backgroundAudioSource;
    float obstacleSpawnRate = 1.7f;
    float potatoSpawnRate = 3f;
    float obstacleSpawnTimer;
    float potatoSpawnTimer;
    bool startedGame = false;

    void Start()
    {
        Time.timeScale = 0;
    }

    void Update()
    {
        if (!startedGame && Input.GetMouseButtonDown(0))
        {
            istructionsPanel.SetActive(false);
            Time.timeScale = 1;
            backgroundAudioSource.Play();
            startedGame = true;
        }

        obstacleSpawnTimer += Time.deltaTime;
        potatoSpawnTimer += Time.deltaTime;

        if(obstacleSpawnTimer >= obstacleSpawnRate)
        {
            obstacleSpawnTimer -= obstacleSpawnRate;
            Vector2 obstaclePostion = new Vector2(Random.Range(10f, 15f), -2.082564f);
            Instantiate(obstacle, obstaclePostion, Quaternion.identity);
        }

        if (potatoSpawnTimer >= potatoSpawnRate)
        {
            potatoSpawnTimer -= potatoSpawnRate;
            Vector2 obstaclePostion = new Vector2(Random.Range(10f, 15f), Random.Range(-2.6f, -0.02f));
            Instantiate(potato, obstaclePostion, Quaternion.identity);
        }
    }
}
