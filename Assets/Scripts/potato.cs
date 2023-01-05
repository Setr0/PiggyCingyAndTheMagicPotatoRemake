using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potato : MonoBehaviour
{

    void Update()
    {
        if (transform.position.x > -10.14f)
        {
            transform.position = new Vector2(transform.position.x - 12f * Time.deltaTime, transform.position.y);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
