using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters : MonoBehaviour
{
    public float visibleZHeight = 0.3f;
    public float hiddenZHeight = 1f;
    private Vector3 myNweXYZPosition;
   
    public GameObject[] characters;

    private float HideTimer = 2f;

    void Start()
    {
        HideCharacters();
    }

    void Update()
    {
        transform.localPosition = myNweXYZPosition;

        HideTimer -= Time.deltaTime;
        if (HideTimer < 0f)
        {
            HideCharacters();

            HideTimer = 2f;
        }
    }

    public void HideCharacters()
    {
        myNweXYZPosition = new Vector3
            (
            transform.localPosition.x,
            transform.localPosition.y,
            hiddenZHeight
            );

        foreach(GameObject character in characters)
        {
            character.GetComponent<BoxCollider2D>().enabled = false;
            character.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
    public void ShowCharacters()
    {
        myNweXYZPosition = new Vector3
            (
            transform.localPosition.x,
            transform.localPosition.y,
            visibleZHeight
            );

        GameObject character = characters[Random.Range(0, characters.Length)];

        character.GetComponent<BoxCollider2D>().enabled = true;
        character.GetComponent<SpriteRenderer>().enabled = true;
    }
}
