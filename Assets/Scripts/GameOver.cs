﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{   

    public void Restart()
    {
        SceneManager.LoadScene("MainLevel");
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");        
    }
}
