using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int scoreNumber;
    void Start()
    {
        scoreNumber = 0;
    }

    void Update()
    {
        GetComponent<Text>().text = scoreNumber.ToString();
    }
}
