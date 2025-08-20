using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public float deathY = -5f;
    public GameObject gameOverUI;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < deathY)
        {
            ShowGameOver();
        }
    }

    public void ShowGameOver()
    {
        Debug.Log("Game Over!");
        rb.simulated = false;
        if (gameOverUI != null)
        {
            gameOverUI.SetActive(true);
            GameTimer gameTimer = FindObjectOfType<GameTimer>();
            if (gameTimer != null)
            {
                gameTimer.timerText.gameObject.SetActive(false);
            }
        }
    }

    public void RetryGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
