//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;

public class GenerateScores : MonoBehaviour
{
    //this function randomly creates the scores for the game and the number of balls
    public void Generate()
    {
        int playerScore = Random.Range(100, 300);
        int computerScore = Random.Range((playerScore + 10), (playerScore + 50));
        SetInt("PlayerScore", playerScore);
        SetInt("ComputerScore", computerScore);

        int remainingBalls = ((((computerScore - playerScore) * 5) / 6) - 5);
        if (remainingBalls < 2)
        {
            remainingBalls = 2;
        }
        SetInt("RemainingBalls", remainingBalls);
    }

    //this function stores the specified value under the specified keyname in the playerprefs dictionary
    public void SetInt(string keyname, int value)
    {
        PlayerPrefs.SetInt(keyname, value);
    }
}