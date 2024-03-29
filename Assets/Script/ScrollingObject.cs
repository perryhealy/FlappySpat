﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScrollingObject : MonoBehaviour
{
    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rb2d.velocity = new Vector2(GameControl.instance.scrollSpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameControl.instance.gameOver)
        {
            rb2d.velocity = Vector2.zero;
        }
    }
}