using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject istructionsPanel;
    public AudioSource backgroundAudioSource;
    float spawnRate = 3f;
    float spawnTimer;
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

        spawnTimer += Time.deltaTime;
        if(spawnTimer >= spawnRate)
        {
            spawnTimer -= spawnRate;
            Vector2 obstaclePostion = new Vector2(Random.Range(10f, 15f), -2.082564f);
            Instantiate(obstacle, obstaclePostion, Quaternion.identity);
        }
    }
}
