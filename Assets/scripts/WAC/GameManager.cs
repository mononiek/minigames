using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text ScoreText;
    public static int Score = 0;
    
    public Text TimerText;
    public float GameTimer = 30f;

    public GameObject PlacesContainer;
    private Characters[] Places;
    private float ShowTimer = 1.5f;
    
    void Start()
    {
        Places = PlacesContainer.GetComponentsInChildren<Characters>();
    }

    void Update()
    {

        ScoreText.text = "Score: " + Score;

        GameTimer -= Time.deltaTime;
        if (GameTimer > 0f)
        {
            TimerText.text = "Timer: " + Mathf.Floor(GameTimer);

            ShowTimer -= Time.deltaTime;
            if (ShowTimer < 0f)
            {
                Places[Random.Range(0, Places.Length)].ShowCharacters();

                ShowTimer = 1.5f;
            }
        }
        else
        {
            TimerText.text = "GAME OVER";
        }
    }
}
