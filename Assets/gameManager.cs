using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject pauseMenu;
    public int scene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Quit()
    {
        Application.Quit();
    }

    bool paused = false;
    public void pause()
    {
        if (paused == true)
        {
            pauseMenu.SetActive(false);
            paused = false;
        }
        pauseMenu.SetActive(true);
        paused = true;
        
    }

    public void unpause()
    {
        pauseMenu.SetActive(false);
        paused = false;
    }

    public void loadScene()
    {
        SceneManager.LoadScene(scene);
    }
}
