using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public float jumpForce = 9f;

    public GameObject pauseButton;
    public GameObject gameOverMenu;
    public Text speed;

    public Rigidbody2D rb;
    public SpriteRenderer sr;

    public string currentColor;
    int index = 0;
    int x = 0;

    public Color colorCyan, colorYellow, colorPurple, colorPink;

    private void Start()
    {
        jumpForce = PlayerPrefs.GetFloat("jumpForce");
        speed.text = jumpForce.ToString("F1");
        Input.simulateMouseWithTouches = enabled;
        Time.timeScale = 1f;
        Score.score = 0;
        SetRandomColor();
    }

    // Update is called once per frame
    void Update()
    {
        speed.text = jumpForce.ToString("F1");        
        if (Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpForce;
        }

        if (transform.position.y < -10f)
        {
            GameOverStart();
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "ColorChanger")
        {
            SetRandomColor();
            Destroy(col.gameObject);
            Score.score++;
            return;
        }

        if (col.tag != currentColor)
        {
            GameOverStart();
        }
    }

    void SetRandomColor()
    {
        x = Random.Range(1, 4);
        index += x;
        if (index == 4)
        {
            index = 0;
        }
        else if (index == 5)
        {
            index = 1;
        }
        else if (index == 6)
        {
            index = 2;
        }
        switch (index)
        {
            case 0:
                currentColor = "Cyan";
                sr.color = colorCyan;
                break;
            case 1:
                currentColor = "Yellow";
                sr.color = colorYellow;
                break;
            case 2:
                currentColor = "Purple";
                sr.color = colorPurple;
                break;
            case 3:
                currentColor = "Pink";
                sr.color = colorPink;
                break;
        }
    }

    public void GameOverStart()
    {
        gameOverMenu.SetActive(true);
        pauseButton.SetActive(false);
        Time.timeScale = 0f;
    }

    public void Plus()
    {
        if (jumpForce < 12f)
        {
            jumpForce += 0.1f;
            PlayerPrefs.SetFloat("jumpForce", jumpForce);
        }
    }

    public void Minus()
    {
        if (jumpForce > 7f)
        {
            jumpForce -= 0.1f;
            PlayerPrefs.SetFloat("jumpForce", jumpForce);
        }
    }
}
