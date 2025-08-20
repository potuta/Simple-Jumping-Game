using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winner : MonoBehaviour
{
    public GameObject winnerUI;
    public GameObject finishLine;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject == finishLine)
        {
            ShowWinner();
        }
    }

    void ShowWinner()
    {
        Debug.Log("You Win!");
        rb.simulated = false;

        if (winnerUI != null)
        {
            winnerUI.SetActive(true);
            GameTimer gameTimer = FindObjectOfType<GameTimer>();
            if (gameTimer != null)
            {
                gameTimer.timerText.gameObject.SetActive(false);
            }
        }
    }
}
