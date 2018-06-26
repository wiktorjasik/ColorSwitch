using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public static int score = 0;
    public Text scoreText, highScoreText;

    // Use this for initialization
    void Start ()
    {
        scoreText.text = score.ToString();
        highScoreText.text = "HighScore: " + PlayerPrefs.GetInt("HighScore").ToString();
    }
	
	// Update is called once per frame
	void Update ()
    {
        scoreText.text = score.ToString();
        if (PlayerPrefs.GetInt("HighScore") < score)
        {
            highScoreText.text = "HighScore: " + score.ToString();
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
}
