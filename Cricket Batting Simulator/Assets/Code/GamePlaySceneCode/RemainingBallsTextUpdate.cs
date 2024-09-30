//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemainingBallsTextUpdate : MonoBehaviour
{
    //this function is called once per frame update
    //this function displays the number of balls remaining in the match
    public void Update()
    {
        int balls = GetInt("RemainingBalls");
        GetComponent<UnityEngine.UI.Text>().text = "Balls Remaining: " + balls;
    }

    //this function retrieves the value stored under the specified keyname in the playerprefs dictionary
    public int GetInt(string keyname)
    {
        return PlayerPrefs.GetInt(keyname);
    }
}
