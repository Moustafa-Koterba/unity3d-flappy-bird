using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject startCanvas;
    public GameObject gameOverCanvas;
    public Rigidbody2D birdRigidbody2D;
    public PipeSpawner pipeSpawner;

    public static bool replay;

    void Start()
    {
        Time.timeScale = 1;
        gameOverCanvas.SetActive(false);

        if (replay)
        {
            Play();
        }
        else
        {
            birdRigidbody2D.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }

    public void Play()
    {
        startCanvas.SetActive(false);
        birdRigidbody2D.constraints = RigidbodyConstraints2D.FreezeRotation;
        pipeSpawner.Launch();
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        replay = true;
        ScoreManager.Score = 0;
        SceneManager.LoadScene(0);
    }
}
