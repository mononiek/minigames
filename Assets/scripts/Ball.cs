using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ball : MonoBehaviour
{
    private bool _isFlat = true;

    private Rigidbody _rigidbody;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tilt = Input.acceleration;

        if (_isFlat)
            tilt = Quaternion.Euler(90, 0, 0) * tilt;

        _rigidbody.AddForce(tilt * 4);
        Debug.DrawRay(transform.position + Vector3.up, tilt, Color.blue);
    }
}