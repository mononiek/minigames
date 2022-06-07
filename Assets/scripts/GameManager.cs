using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text TimerText;
    public float GameTimer = 30f;

    public GameObject PlacesContainer;
    private Characters[] Places;
    public float ShowTimer = 5f;
    
    void Start()
    {
        Places = PlacesContainer.GetComponentsInChildren<Characters>();
        Debug.Log(Places.Length);
    }

    void Update()
    {
        GameTimer -= Time.deltaTime;
        if (GameTimer > 0f)
        {
            TimerText.text = "Timer: " + Mathf.Floor(GameTimer);

            ShowTimer -= Time.deltaTime;
            if (ShowTimer < 0f)
            {
                Places[Random.Range(0, Places.Length)].ShowCharacters();

                ShowTimer = 5f;
            }
        }
        else
        {
            TimerText.text = "GAME OVER";
        }
    }
}
