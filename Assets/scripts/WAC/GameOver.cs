using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text EndScoreText;

    private void Start()
    {
        gameObject.SetActive(false);
    }
    public void Restart()
    {
        SceneManager.LoadScene("Whack A Clown"); 
    }

    public void Back()
    {
        SceneManager.LoadScene("Games menu");
    }

        
    public void UpdateText()
    {
        EndScoreText.text = "Score: " + GameManager.Score;
    }
}
