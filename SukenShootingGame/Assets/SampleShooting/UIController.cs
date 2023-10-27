using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    int score = 0;
    GameObject scoreText;
    GameObject gameOverText;
    
    public void GameOver() {
        this.gameOverText.GetComponent<Text>().text = "GameOver";
        SceneManager.LoadScene("New Scene");
    }
    
    public void AddScore() {
        this.score += 10;
    }
    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = GameObject.Find("Score");
        this.gameOverText = GameObject.Find("GameOver");
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.GetComponent<Text>().text = "Score:" + score.ToString("D4");
    }
}
