using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryGameController : MonoBehaviour
{
    public GameObject istructionsPanel;
    public static bool gameReady = false;
    void Start()
    {
        Time.timeScale = 0;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            istructionsPanel.SetActive(false);
            Time.timeScale = 1;
        }
    }
}
