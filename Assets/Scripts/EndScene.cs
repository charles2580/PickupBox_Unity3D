using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    public Text r_socre;
    public Text r_time;
    public Text r_bscore;

    private void Awake()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

    }
    // Start is called before the first frame update
    private void Start()
    {
        if(SceneManager.GetActiveScene().name == "EndGame")
        {
            SuccessRecord();
        }
        if(SceneManager.GetActiveScene().name == "FailedScene")
        {
            FailedRecord();
        }
    }
    public void ExitButton()
    {
        PlayerPrefs.DeleteKey("Best_Score");
        Application.Quit();
    }

    public void RestartButton()
    {
        PlayerPrefs.SetInt("Best_Score", ScoreText.score);
        Dead.h_count = 3;
        GameTimer.time = 303.0f;
        ScoreText.score = 0;
        SceneManager.LoadScene(0);
    }

    public void SuccessRecord()
    {
        int minutes = Mathf.FloorToInt(GameTimer.time / 60);
        int seconds = Mathf.FloorToInt(GameTimer.time - minutes * 60);
        r_time.text = string.Format("Clear Time {0:0}:{1:00}", minutes, seconds);
        r_socre.text = "Your Score : " + ScoreText.score;
        if(BestScore.best == 0 && BestScore.best <ScoreText.score)
        {
            r_bscore.text = "Best Score : " + ScoreText.score;
        }
        else
        {
            r_bscore.text = "Best Score : " + BestScore.best;
        }
    }

    public void FailedRecord()
    {
        if (BestScore.best == 0 && BestScore.best < ScoreText.score)
        {
            r_bscore.text = "Best Score : " + ScoreText.score;
        }
        else
        {
            r_bscore.text = "Best Score : " + BestScore.best;
        }
        r_socre.text = "Your Score : " + ScoreText.score;
        r_time.text = "You Failed";
    }
}
