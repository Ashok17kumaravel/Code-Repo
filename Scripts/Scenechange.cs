using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenechange : MonoBehaviour
{
    public void changescene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void quitapp()
    {
        Application.Quit();
    }
}