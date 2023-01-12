using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChooseCharacter : MonoBehaviour
{
    public static String character;
    public void loadGame(int scene)
    {
        character = this.GetComponentInChildren<Text>().text.ToLower();
        SceneManager.LoadScene(scene);
    }
}
