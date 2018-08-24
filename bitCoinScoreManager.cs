using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class bitCoinScoreManager : MonoBehaviour {

    public static int score;

    Text text;

    void Start()
    {
        text = GetComponent<Text>();

        //score = 0;

        score = PlayerPrefs.GetInt("CurrentPlayerScore");
    }

    void Update()
    {
        if (score < 0)
            score = 0;

        if (score == 0)
            text.text = "000,000";



        if (score <= 90)
        {
            if (score > 0)
            {
                text.text = "0,000" + score;
            }
        }
        if (score <= 999)
        {
            if (score >= 100)
            {
                text.text = "000" + score;
            }
        }
        if (score <= 9999)
        {
            if (score >= 1000)
            {
                text.text = "00" + score;
            }
        }
        if (score <= 99999)
        {
            if (score >= 10000)
            {
                text.text = "0" + score;
            }
        }

        if (score <= 999999)
        {
            if (score >= 100000)
            {
                text.text = "" + score;
            }
        }

    }

    public static void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
        PlayerPrefs.SetInt("CurrentPlayerScore", score);
    }

    public static void DeductPoints(int pointsToDeduct)
    {
        score -= pointsToDeduct;
        PlayerPrefs.SetInt("CurrentPlayerScore", score);
    }

    public static void Reset()
    {
        score = 0;
        PlayerPrefs.SetInt("CurrentPlayerScore", score);
    }
}