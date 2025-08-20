using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    public float timeRemaining = 30f;
    public TMP_Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            timerText.text = $"Time: {Mathf.Ceil(timeRemaining).ToString()}";
        }
        else
        {
            GameOver gameOver = FindObjectOfType<GameOver>();
            if (gameOver != null)
            {
                gameOver.ShowGameOver();
            }
        }
    }
}
