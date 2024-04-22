using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Ball : MonoBehaviour
{
    public float clampSpeed = 7f;
    public float minAngle = 45f;
    public float maxAngle = 120f;
    public float velocityMagnitude = 5f;

    private Rigidbody2D rb;
    public GameObject gameOverPanel;
    public GameObject winPanel;
    public GameObject gamePanel;
    private int blockCount;
    private int score = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI scoreText1;
    public TextMeshProUGUI highScoreText2;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector2 randomDirection = Quaternion.Euler(0, 0, Random.Range(minAngle, maxAngle)) * Vector2.right;
        rb.velocity = randomDirection * velocityMagnitude;
        blockCount = GameObject.FindGameObjectsWithTag("Block").Length;
    }

    void Update()
    {
        UpdateHighScore();
        if (rb.velocity.magnitude > clampSpeed)
        {
            rb.velocity = Vector3.ClampMagnitude(rb.velocity, clampSpeed);
        }
        if (blockCount == 0)
        {
            winPanel.SetActive(true);
            gamePanel.SetActive(false);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Block"))
        {
            score++;
            PlayerPrefs.SetInt("score", score);
            Destroy(collision.gameObject);
            blockCount--;
        }
    }

    private void OnBecameInvisible()
    {
        scoreText.text = "Your Score: " + score.ToString();
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("highscore");
        scoreText1.text = "Your Score: " + score.ToString();
        highScoreText2.text = "High Score: " + PlayerPrefs.GetInt("highscore");
        gameOverPanel.SetActive(true);
        gamePanel.SetActive(false);
    }

    private void UpdateHighScore()
    {
        if (score > PlayerPrefs.GetInt("highscore"))
            PlayerPrefs.SetInt("highscore", score);
    }
}
