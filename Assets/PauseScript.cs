using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public static bool Paused = false;
    public GameObject PauseMenu;
    public void PauseButton()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
    }
    public void MainMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Paused == true)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
        void Pause()
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
            Paused = true;
        }
        void Resume()
        {
            PauseMenu.SetActive(false);
            Time.timeScale = 1f;
            Paused = false;
        }
    }
}
