using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Characters : MonoBehaviour
{
    public float visibleZHeight = 0.3f;
    public float hiddenZHeight = 1f;
    private Vector3 myNweXYZPosition;
   
    public GameObject[] characters;

    public float HideTimer = 1.5f;


    void Start()
    {
        HideCharacters();

        transform.localPosition = myNweXYZPosition;
    }

    void Update()
    {
        //HideTimer -= Time.deltaTime;
        //if (HideTimer < 0f)
        //{
            //HideCharacters();

            //HideTimer = 1.5f;
        //}
    }

    public void HideCharacters()
    {
        myNweXYZPosition = new Vector3
            (
            transform.localPosition.x,
            transform.localPosition.y,
            hiddenZHeight
            );
    }
    public void ShowCharacters()
    {
        myNweXYZPosition = new Vector3
            (
            transform.localPosition.x,
            transform.localPosition.y,
            visibleZHeight
            );

    }
}
