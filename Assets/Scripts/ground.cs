using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    Vector2 startPosition;
    public static bool started = true;
    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        if(transform.position.x >= -15.39f)
        {
            started = false;
            transform.position = new Vector2(transform.position.x - 15f * Time.deltaTime,
                transform.position.y);
        }
        else
        {
            started = true;
            transform.position = startPosition;
        }
    }
}
