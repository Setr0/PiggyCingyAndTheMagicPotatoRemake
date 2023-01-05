using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class obstacle : MonoBehaviour
{
    bool passed = false;
    public AudioSource audioSource;
    void Update()
    {
        if(transform.position.x > -10.14f)
        {
            transform.position = new Vector2(transform.position.x - 3f * Time.deltaTime, transform.position.y);
        }
        else
        {
            Destroy(gameObject);
        }    

        if(!passed && transform.position.x < -6.70f)
        {
            score.scoreNumber += 1;
            audioSource.Play();
            passed = true;
        }
    }
}
