//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScoreTextUpdate : MonoBehaviour
{
    //this function is called once per frame update
    //this function tells the user thier current score
    public void Update()
    {
        int score = GetInt("PlayerScore");
        GetComponent<UnityEngine.UI.Text>().text = "Current Score: " + score;
    }

    //this function retreieves the value stored under the specified keyname in the playerprefs dictionary
    public int GetInt(string keyname)
    {
        return PlayerPrefs.GetInt(keyname);
    }
}
