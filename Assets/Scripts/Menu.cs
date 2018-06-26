using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    private void Start()
    {
        Time.timeScale = 1f;
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainLevel");
        Score.score = 0;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
