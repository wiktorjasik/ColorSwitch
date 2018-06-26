using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

    public GameObject pauseButton;
    public GameObject pauseMenu;
    
    public void PauseStart()
    {
        pauseMenu.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1f;
    }

    public void GoToMenu()
    {
        Resume();
        SceneManager.LoadScene("Menu");        
    }
    
}
