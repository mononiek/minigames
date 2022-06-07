using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    float playerMovingSpeed = 20f;

    void FixedUpdate()
    {
        transform.Translate(Input.acceleration.x * playerMovingSpeed * Time.deltaTime,
                             Input.acceleration.y * playerMovingSpeed * Time.deltaTime, 0);

    }
}