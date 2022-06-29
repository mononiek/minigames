using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangingScenes : MonoBehaviour
{
    public void StartWAC()
    {
        SceneManager.LoadScene("Start WAC");
    }

    public void StartLAB()
    {
        SceneManager.LoadScene("Start LAB");
    }

    public void BackToMain()
    {
        SceneManager.LoadScene("Games menu");
    }
    public void WhackAClown()
    {
        SceneManager.LoadScene("Whack A Clown");
    }

    public void Labyrinth()
    {
        SceneManager.LoadScene("Labyrinth Level-1");
    }
    public void LabNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
