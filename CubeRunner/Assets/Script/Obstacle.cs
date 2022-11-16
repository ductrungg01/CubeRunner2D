using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Obstacle : MonoBehaviour
{
    public float speedMove = 5.0f;

    GameController _gc;

    // Start is called before the first frame update
    void Start()
    {
        _gc = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += Vector3.left * Time.deltaTime * speedMove;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("DeathZone"))
        {
            _gc.IncScore();
            Destroy(gameObject);
        }
    }
}
