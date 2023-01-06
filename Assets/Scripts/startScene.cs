using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    public static void start(int scene)
    {
        SceneManager.LoadScene(scene);
    }
}
