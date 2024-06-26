using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public Text scoreText;
    public Text win;

    int score = 0;

    private void Awake() {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString() + " POINTS";
        win.text = "";

    }

    // Update is called once per frame
    public void AddPoint()
    {
        score+=1;
        scoreText.text = score.ToString() + " POINTS";
        if (score < 500 || score > 500)
        {
            win.text = "You Lose!";
        }
        else 
        {
            win.text = "You Win!";
        }
    }
}
