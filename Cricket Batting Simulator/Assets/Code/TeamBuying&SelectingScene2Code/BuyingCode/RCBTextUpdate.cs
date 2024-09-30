//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RCBTextUpdate : MonoBehaviour
{           
    //initialize variables
    public string RCBOwned;
    public string selectedTeam;
    public string insufficientCoins;
    
    //this function is called once per frame update
    //this function tells the user the status of the team, whether it is owned, selected, or unable to be purchased    
    public void Update()
    {
        RCBOwned = GetString("RCBOwned");
        if (RCBOwned == "True")
        {
            GetComponent<UnityEngine.UI.Text>().text = "Team Owned";
        }

        selectedTeam = GetString("SelectedTeam");
        if (selectedTeam == "RCB")
        {
            GetComponent<UnityEngine.UI.Text>().text = "Team Selected";
        }

        insufficientCoins = GetString("NotEnoughCoinsForRCB");
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
        SetString("NotEnoughCoinsForRCB", "False");
        GetComponent<UnityEngine.UI.Text>().text = "Buy For $10000000";
    }
}
