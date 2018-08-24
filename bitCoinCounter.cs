using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class bitCoinCounter : MonoBehaviour {

    public static int score;

    Text text;

    void Start()
    {
        text = GetComponent<Text>();

        score = 0;


    }

    void Update()
    {
        if (score < 0)
        {
            score = 0;
            text.text = "000" ;
        }

        if (score > 0 && score <= 9){

            text.text = "00" + score;
        }
              
        if (score > 9 && score <= 99)
        {

            text.text = "0" + score;
        }
         
        }





    public static void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
       
    }

   

    public static void Reset()
    {
        score = 0;
      
    }
}