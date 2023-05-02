using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public BirdScript bird;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI clock;
    public GameObject playButton;
    public GameObject gameOver;

    private int score;
    private float gameTime;

    private void ResetClock()
    {
        clock.text = "";
        gameTime = 0;
    }

    public void Awake()
    {
        Application.targetFrameRate = 60;
        Pause();
    }

    public void Update()
    {
        gameTime += Time.deltaTime;
        clock.text = "Clock: " + (((int)(gameTime * 10)) / 10f).ToString("F1");
    }

    public void Play()
    {
        ResetClock();

        score = 0;
        scoreText.text = "Score: " + score.ToString();

        playButton.SetActive(false);
        gameOver.SetActive(false);

        Time.timeScale = 1f;
        bird.enabled = true;

        TubeScript[] tubes = FindObjectsOfType<TubeScript>();

        for (int i = 0; i < tubes.Length; i++)
            Destroy(tubes[i].gameObject);
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        bird.enabled = false;
    }

    public void GameOver()
    {
        gameOver.SetActive(true);
        playButton.SetActive(true);

        Pause();
    }

    public void IncreaseScore() 
        => scoreText.text = "Score: " + (++score).ToString();
}
