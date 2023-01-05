using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground : MonoBehaviour
{
    Vector2 startPosition;
    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        if(transform.position.x > -1.19f)
        {
            transform.position = new Vector2(transform.position.x - 8f * Time.deltaTime,
                transform.position.y);
        }
        else
        {
            transform.position = startPosition;
        }
    }
}
