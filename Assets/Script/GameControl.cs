using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour {
    public static GameControl instance;
    public Text scoreText;
    public GameObject gameOverText;

    private int score = 0;
    public bool gameOver = false;
    public float scrollSpeed = -1.5f;

	// Use this for initialization
	void Awake () {
        if (instance == null) {
            instance = this;
        } else if (instance != this) {
            Destroy(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (gameOver && Input.GetMouseButtonDown(0)) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
	}

    public void SpatScored() {
        if (gameOver)
        {
            return;
        }

        score++;
        string zeros = "";
        if (score < 10) {
            zeros = "00";
        } else if (score < 100) {
            zeros = "0";
        }
        scoreText.text = zeros + "" + score;
    }

    public void SpatFell() {
        gameOverText.SetActive(true);
        gameOver = true;
    }
}
