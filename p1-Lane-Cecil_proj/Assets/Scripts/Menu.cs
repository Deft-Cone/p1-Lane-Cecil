using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject pauseMenuScreen;
    public bool VFX = false; 
    public void ReturnToMenu ()
    {
        SceneManager.LoadScene("Start Scene");
    }
    
    public void TurnVFXOn ()
    {
        if (VFX)
        {
            VFX = false;
        }
        else
        {
            VFX = true; 
        }
    }
    public void Pause ()
    {
        pauseMenuScreen.SetActive(true);
        Time.timeScale = 0f;
    }
    
    public void Resume ()
    {
        pauseMenuScreen.SetActive(false);
        Time.timeScale = 1f;
    }
}