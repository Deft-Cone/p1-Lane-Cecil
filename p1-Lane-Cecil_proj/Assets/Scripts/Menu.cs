using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject pauseMenuScreen;
    public bool VFX = false; 
    //public GameObject scoreText;
    //public WallObjectCollide points;
    public GameObject collisionCam;
    public void ReturnToMenu ()
    {
        SceneManager.LoadScene("Start Scene");
    }
    
    public void Restart ()
    {
        SceneManager.LoadScene("Main Scene");
    }
    
    
    public void TurnVFXOn ()
    {
        if (VFX)
        {
            VFX = false;
            collisionCam.SetActive(false);
        }
        else
        {
            collisionCam.SetActive(true);
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
    
    void Update()
    {
        //scoreText.GetComponent<Text>().text = points.score.ToString();
        //scoreText.text = points.score.ToString();
    }
}