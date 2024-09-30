//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    //this function is called once per frame update
    //this function checks whether the game has ended based on the player outscoring the computer or the balls running out
    public void Update()
    {
        int playerScore = GetInt("PlayerScore");
        int computerScore = GetInt("ComputerScore");
        int remainingBalls = GetInt("RemainingBalls");

        if (playerScore > computerScore || remainingBalls == 0)
        {
            SceneManager.LoadScene("ResultsScene");
        }
    }

    //this function retreieves the value stored under the specified keyname in the playerprefs dictionary
    public int GetInt(string keyname)
    {
        return PlayerPrefs.GetInt(keyname);
    }
}
