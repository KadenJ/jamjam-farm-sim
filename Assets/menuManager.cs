using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuManager : MonoBehaviour
{
    public int scene;
    public void loadScene()
    {
        SceneManager.LoadSceneAsync(scene);
    }

    public void exit()
    {
        Application.Quit();
    }
}
