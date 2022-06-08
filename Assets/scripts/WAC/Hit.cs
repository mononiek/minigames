using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    private AudioSource sound;
    public int Value = 1;


    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {       
        GameManager.Score += Value;
        sound.Play();

        gameObject.GetComponent<BoxCollider2D>().enabled = false;
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }

}
