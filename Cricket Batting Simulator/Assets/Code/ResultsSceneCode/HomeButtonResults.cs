//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButtonResults : MonoBehaviour
{
    //this function resets values pertaining to the cricket match just played and loads the home page
    public void Home()
    {
        SceneManager.LoadScene("MainMenuScene");

        SetInt("RemainingBalls", 0);
        SetInt("ComputerScore", 0);
        SetInt("PlayerScore", 0);
        SetInt("PreviousBallRuns", 0);
        SetString("BallRollFar", "False");
        SetString("BowlType", "");
        SetString("BallRollShort", "False");
    }

    //this function stores the specified value under the specified keyname in the playerprefs dictionary
    public void SetString(string keyname, string value)
    {
        PlayerPrefs.SetString(keyname, value);
    }

    //this function stores the specified value under the specified keyname in the playerprefs dictionary
    public void SetInt(string keyname, int value)
    {
        PlayerPrefs.SetInt(keyname, value);
    }
}
