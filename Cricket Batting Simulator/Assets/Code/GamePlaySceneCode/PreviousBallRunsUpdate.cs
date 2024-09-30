//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreviousBallRunsUpdate : MonoBehaviour
{
    //this function is called once per frame update
    //this function tells the user how many runs were scored on the most recent ball
    public void Update()
    {
        int score = GetInt("PreviousBallRuns");
        GetComponent<UnityEngine.UI.Text>().text = score + " runs";
    }

    //this function retreieves the value stored under the specified keyname in the playerprefs dictionary
    public int GetInt(string keyname)
    {
        return PlayerPrefs.GetInt(keyname);
    }
}
