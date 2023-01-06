using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    Vector2 startPosition;
    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        if(transform.position.x >= -2.40f)
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
