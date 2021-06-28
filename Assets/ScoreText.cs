using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreText : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;

    void Start()
    {
        score = 0;
        SetScore();
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "LargeStarTag")
        {
            score += 10;
        }
        SetScore();


        if (other.gameObject.tag == "SmallStarTag")
        {
            score += 5;
        }
        SetScore();


        if (other.gameObject.tag == "LargeCloudTag")
        {
            score += 20;
        }
        SetScore();

        if (other.gameObject.tag == "SmallCloudTag")
        {
            score += 15;
        }
        SetScore();

    }

    
    void SetScore()
    {
        scoreText.text = string.Format("{0}", score);
    }
}
