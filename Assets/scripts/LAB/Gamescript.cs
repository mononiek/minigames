using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gamescript : MonoBehaviour
{
    public Text TimerText;
    public float Timer = 0f;
    public GameObject NextLevel;

    void Start()
    {
        Timer = 0f;
    }
    void Update()
    {
        if (NextLevel.activeSelf) return;

        Timer += Time.deltaTime;
        TimerText.text = "" + Mathf.Round(Timer * 100) /100.0;

        
    }
}
