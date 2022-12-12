using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class ScoreKeeper : MonoBehaviour
{
    public static ScoreKeeper instance;

    public TMP_Text scoreText;
    public TMP_Text highscoreText;

    private int scoreCounter;
    private int highscoreCounter;

   
    void Awake() {
        instance = this;    
    }
 // Start is called before the first frame update
    void Start()
    {
        highscoreCounter = PlayerPrefs.GetInt("highscoreCounter",0);
        scoreCounter = 0;
        highscoreCounter = 0;
        scoreText.text = "SCORE : " + scoreCounter;
        highscoreText.text = "HIGHSCORE : " + highscoreCounter;
    }

    public void IncreaseScore()
    {
        // When meteor is destroyed, call this function for points.
        scoreCounter+=1;
        scoreText.text = "Score : " + scoreCounter;
        if(highscoreCounter<scoreCounter){
            PlayerPrefs.SetInt("highscoreCounter",scoreCounter);
        }
        
    }
}
