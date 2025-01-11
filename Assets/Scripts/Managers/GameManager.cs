using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // GM's singleton for easy access throughout the whole project
    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }

    public static int finalScore = 0;

    [SerializeField]
    private TextMeshProUGUI scoreTextObject = null; 

    private int score = 0;
    public string levelName;
    public SpriteRenderer spriteRenderer;
    public SpriteRenderer spriteRenderer1;
    private float alpha = 0;
    private float color = 0;
    private float _time;
    private float _interval = 2.0f;
    private bool isPaused;

    [SerializeField]
    private GameObject player = null;
    public GameObject Player { get { return player; } }

    private void Awake()
    {
        // setup singleton
        if (instance != null)
            Destroy(instance.gameObject);
        instance = this;
        spriteRenderer.color = new Color(0, 0, 0, alpha);
    }

    private void Update()
    {
        if(score >= 1000)
        {
            FadeToBlack();
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
    }
    public void NotifyPlayerDeath()
    {
        // save final score then go to game over screen
        finalScore = score;
        SceneManager.LoadScene("GameOver");
        score = 0;
    }

    public void AddScore(int amount)
    {
        // increase score and update UI
        score += amount;

        if (scoreTextObject != null)
            scoreTextObject.text = "Score: " + score.ToString() + "/1000";
    }

    private void FadeToBlack()
    {
        _time += Time.deltaTime;
        while (_time >= _interval)
        {
            score = 0;
            SceneManager.LoadScene(levelName);
            _time -= _interval;
        }
        if (_time < _interval)
        {
            alpha += Time.deltaTime;
            spriteRenderer.color = new Color(0, 0, 0, alpha);
        }
    }


    private void PauseGame()
    {

        isPaused = !isPaused;
        Time.timeScale = isPaused ? 0 : 1;
        color = isPaused ? 255 : 0;
        spriteRenderer1.color = new Color(color, color, color, color);
    }
}
