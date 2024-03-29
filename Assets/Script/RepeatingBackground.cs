﻿using System.Collections;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour {

    private BoxCollider2D groundCollider;
    private float groundHorizontalLength;

    // Awake is called before Start
    void Awake () {
        groundCollider = GetComponent<BoxCollider2D>();
        groundHorizontalLength = groundCollider.size.x * 5;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < -groundHorizontalLength) {
            RepositionBackground();
        }
	}

    private void RepositionBackground() {
        Vector2 groundOffSet = new Vector2(groundHorizontalLength * 2f, 0);
        transform.position = (Vector2)transform.position + groundOffSet;
    }
}
