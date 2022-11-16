using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    int heightOfJump = 950;
    public int score = 0;
    Rigidbody2D _rb;
    bool isOnTheGround;

    GameController _gc;

    public AudioSource aus;
    public AudioClip jump;
    public AudioClip lose;

    // Start is called before the first frame update
    void Start()
    {
        _gc = FindObjectOfType<GameController>();
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isJump = Input.GetKeyDown(KeyCode.Space);

        if (isJump && isOnTheGround)
        {
            Jump();
        }
    }

    public void Jump()
    {
        _rb.AddForce(Vector2.up * new Vector2(0, heightOfJump));

        isOnTheGround = false;

        if (aus != null && jump != null && !_gc.isGameover)
        {
            aus.PlayOneShot(jump);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            Debug.Log("GameOver");

            if (aus != null && lose != null && !_gc.isGameover)
            {
                aus.PlayOneShot(lose);
            }

            _gc.SetGameoverState(true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnTheGround = true;
        }
    }
}
