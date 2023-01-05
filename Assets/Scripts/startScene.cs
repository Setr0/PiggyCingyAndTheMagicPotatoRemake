using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startScene : MonoBehaviour
{
    public static void start(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
