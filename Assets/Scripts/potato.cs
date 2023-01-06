using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potato : MonoBehaviour
{

    void Update()
    {
        if (transform.position.x > -10.14f)
        {
            transform.position = new Vector2(transform.position.x - 16f * Time.deltaTime, transform.position.y);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
