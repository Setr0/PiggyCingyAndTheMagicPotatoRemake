using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryPlayerController : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y > -17.77f)
        {
            transform.position = new Vector2(transform.position.x,
            transform.position.y - 3f * Time.deltaTime);
        }
        else
        {
            StoryGameController.gameReady = true;
        }
    }
}
