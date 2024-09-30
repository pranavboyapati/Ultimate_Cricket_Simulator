//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLossTextUpdate : MonoBehaviour
{
    //initialize variables
    public int PlayerScore;
    public int ComputerScore;

    //this function is called once per frame update
    //this function tells the user whether they won or lost the game
    public void Update()
    {
        PlayerScore = GetInt("PlayerScore");
        ComputerScore = GetInt("ComputerScore");

        if (PlayerScore > ComputerScore)
        {
            GetComponent<UnityEngine.UI.Text>().text = "You Win!";
        }
        else if (PlayerScore == ComputerScore)
        {
            GetComponent<UnityEngine.UI.Text>().text = "Draw";
        }
        else if (PlayerScore < ComputerScore)
        {
            GetComponent<UnityEngine.UI.Text>().text = "Uh Oh, You Lost";
        }
    }

    //this function retrieves the value stored under the specified keyname in the playerprefs dictionary
    public int GetInt(string Keyname)
    {
        return PlayerPrefs.GetInt(Keyname);
    }
}
