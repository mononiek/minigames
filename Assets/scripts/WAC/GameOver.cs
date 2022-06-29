using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text EndScoreText;
    public Text HighScoreText;

    private void Start()
    {
        gameObject.SetActive(false);
    }
   
    public void UpdateText()
    {
        HighScoreText.text = "Highscore: " + GameManager.HighScore;
        EndScoreText.text = "Score: " + GameManager.Score;
    }
}
