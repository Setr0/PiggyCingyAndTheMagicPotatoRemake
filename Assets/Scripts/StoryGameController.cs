using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryGameController : MonoBehaviour
{
    public GameObject istructionsPanel;
    public GameObject rocks;
    public static bool gameReady = false;
    bool startedGame = false;
    float spawnTimer;
    float spawnRate = 1f;
    void Start()
    {
        Time.timeScale = 0;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !startedGame)
        {
            istructionsPanel.SetActive(false);
            Time.timeScale = 1;
            startedGame = true;
        }

        if(gameReady)
        {
            spawnTimer += Time.deltaTime;
            if (spawnTimer >= spawnRate)
            {
                spawnTimer -= spawnRate;
                Vector2 spawnPosition = new Vector2(Random.Range(-4.24f, 7.24f), Random.Range(-19.7f, -21.7f));
                Instantiate(rocks, spawnPosition, Quaternion.identity);
            }
        }
    }
}
