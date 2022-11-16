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

    // Start is called before the first frame update
    void Start()
    {
        _gc = FindObjectOfType<GameController>();
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isKeyJumpPressed = Input.GetKeyDown(KeyCode.Space);

        if (isKeyJumpPressed && isOnTheGround)
        {
            _rb.AddForce(Vector2.up * new Vector2(0, heightOfJump));

            isOnTheGround = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            Debug.Log("GameOver");
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
