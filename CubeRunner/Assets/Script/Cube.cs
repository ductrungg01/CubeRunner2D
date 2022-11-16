using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public int heightOfJump = 480;
    public int score = 0;
    Rigidbody2D _rb;

    // Start is called before the first frame update
    void Start()
    {
        _rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isKeyJumpPressed = Input.GetKeyDown(KeyCode.Space);

        if (isKeyJumpPressed)
        {
            _rb.AddForce(Vector2.up * new Vector2(0, heightOfJump));
            score++;
        }
    }
}
