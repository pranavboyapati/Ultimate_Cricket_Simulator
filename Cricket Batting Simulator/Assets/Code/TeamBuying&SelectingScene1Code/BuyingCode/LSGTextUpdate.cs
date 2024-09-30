//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LSGTextUpdate : MonoBehaviour
{        
    //initialize variables
    public string LSGOwned;
    public string selectedTeam;
    public string insufficientCoins;
    
    //this function is called once per frame update
    //this function tells the user the status of the team, whether it is owned, selected, or unable to be purchased
    public void Update()
    {
        LSGOwned = GetString("LSGOwned");
        if (LSGOwned == "True")
        {
            GetComponent<UnityEngine.UI.Text>().text = "Team Owned";
        }

        selectedTeam = GetString("SelectedTeam");
        if (selectedTeam == "LSG")
        {
            GetComponent<UnityEngine.UI.Text>().text = "Team Selected";
        }

        insufficientCoins = GetString("NotEnoughCoinsForLSG");
        if (insufficientCoins == "True")
        {
            GetComponent<UnityEngine.UI.Text>().text = "Not Enough Coins";
            Invoke("RestorePreviousText", 3.0f);
        }
    }

    //this function retrieves the value stored under the specified keyname in the playerprefs dictionary
    public string GetString(string Keyname)
    {
        return PlayerPrefs.GetString(Keyname);
    }

    //this function retrieves the value stored under the specified keyname in the playerprefs dictionary
    public void SetString(string Keyname, string Value)
    {
        PlayerPrefs.SetString(Keyname, Value);
    }

    //this function restores the text to the purchase cost after the user is told they can't afford the team
    public void RestorePreviousText()
    {
        SetString("NotEnoughCoinsForLSG", "False");
        GetComponent<UnityEngine.UI.Text>().text = "Buy For $10000000";
    }
}
