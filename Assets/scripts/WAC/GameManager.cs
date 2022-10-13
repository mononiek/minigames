using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text ScoreText;
    public static int Score = 0;
    public static int HighScore = 0;
    
    public Text TimerText;
    public float GameTimer = 30f;

    public GameObject PlacesContainer;
    private Characters[] Places;
    private float ShowTimer = 1f;

    private AudioSource Scarysound;
    private bool playedsound = false;
    public GameObject Jumpscare;
    public float JumpscareTimer = 1f;

    public GameObject GameOver;
    public GameObject BackgroundMusic;
    
    void Start()
    {
        Score = 0;
        HighScore = PlayerPrefs.GetInt("Highscore");
        Places = PlacesContainer.GetComponentsInChildren<Characters>();
        Jumpscare.SetActive(false);
        BackgroundMusic.SetActive(true);
        Scarysound = GetComponent<AudioSource>();
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

                ShowTimer = 1f;
            }
        }
        else
        {
            BackgroundMusic.SetActive(false);
            Jumpscare.SetActive(true);
            if (!playedsound)
            {
                Scarysound.Play();
            }
            playedsound = true;

            JumpscareTimer -= Time.deltaTime;
            if (JumpscareTimer < 0f)
            {
                Jumpscare.SetActive(false);
            }
            TimerText.text = "GAME OVER";
            GameOver.SetActive(true);
            GameOver.GetComponent<GameOver>().UpdateText();

            if (Score > HighScore)
            {
                HighScore = Score;
                PlayerPrefs.SetInt("Highscore", HighScore);
            }
        }
    }
}
