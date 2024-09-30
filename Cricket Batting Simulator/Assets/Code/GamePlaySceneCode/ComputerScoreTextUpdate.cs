//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerScoreTextUpdate : MonoBehaviour
{
    //this function is called once per frame update
    //this function tells the user the computer's score, which is their target score
    public void Update()
    {
        int score = GetInt("ComputerScore");
        GetComponent<UnityEngine.UI.Text>().text = "Target Score: " + score;
    }

    //this function retreieves the value stored under the specified keyname in the playerprefs dictionary
    public int GetInt(string keyname)
    {
        return PlayerPrefs.GetInt(keyname);
    }
}
