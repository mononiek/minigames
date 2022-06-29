using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ball : MonoBehaviour
{
    public GameObject GameOver;
    public GameObject NextLevel;

    int playerLayer, enemyLayer, endLayer;

    private bool _isFlat = true;

    private Rigidbody _rigidbody;
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();

        GameOver.SetActive(false);
        NextLevel.SetActive(false);

        playerLayer = this.gameObject.layer;
        enemyLayer = LayerMask.NameToLayer("Enemy");
        endLayer = LayerMask.NameToLayer("End");
        Physics.IgnoreLayerCollision(playerLayer, enemyLayer, false);
        Physics.IgnoreLayerCollision(playerLayer, endLayer, false);
    }

    void Update()
    {
        Vector3 tilt = Input.acceleration;

        if (_isFlat)
            tilt = Quaternion.Euler(90, 0, 0) * tilt;

        _rigidbody.AddForce(tilt * 20);
        Debug.DrawRay(transform.position + Vector3.up, tilt, Color.blue);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag.Equals("Enemy"))
        {
            GameOver.SetActive(true);
            _rigidbody.constraints = RigidbodyConstraints.FreezeAll;
        }

        if (col.gameObject.tag.Equals("End"))
        {
            NextLevel.SetActive(true);
            _rigidbody.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}