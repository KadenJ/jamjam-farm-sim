using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuManager : MonoBehaviour
{

    public int scene;
    public void loadScene()
    {

        StartCoroutine(wait());
    }

    public void exit()
    {
        Application.Quit();
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(.3f);
        SceneManager.LoadSceneAsync(scene);
    }

}
