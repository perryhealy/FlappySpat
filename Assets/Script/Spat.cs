using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spat : MonoBehaviour {
    public float upShot;
    private bool isDown = false;

    private Animator anim;
    private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (!isDown)
        {
            if (Input.GetMouseButtonDown(0))
            {
                anim.SetTrigger("Flap");
                rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, upShot));
            }
        }
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
        rb2d.velocity = Vector2.zero;
        isDown = true;
        if (collision.gameObject.tag.Equals("Ground"))
        {
            anim.SetTrigger("Out");
        } else 
        {
            anim.SetTrigger("Fall");
        }
        GameControl.instance.SpatFell();
  	}
}
