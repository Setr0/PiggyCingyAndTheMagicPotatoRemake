using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potato : MonoBehaviour
{

    void Update()
    {
        if (transform.position.x > -12.6f)
        {
            transform.position = new Vector2(transform.position.x - 23f * Time.deltaTime, transform.position.y);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
