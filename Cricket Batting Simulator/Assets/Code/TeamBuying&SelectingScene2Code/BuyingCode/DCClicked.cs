//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DCClicked : MonoBehaviour
{
    //initialize variables
    public int coins;
    public string DCOwned;
    
    //this function allows the user to purchase the team if they don't already own it and have enough coins, selects the team if it is owned,
    //or tells the user they can't afford the team if they don't have enough coins to make the purchase
    public void Clicked()
    {
        coins = GetInt("Cash");
        DCOwned = GetString("DCOwned");

        if (DCOwned == "True")
        {
            SetString("SelectedTeam", "DC");
        }

        if (coins >= 10000000)
        {
            if (DCOwned == "False")
            {
                coins -= 10000000;
                SetInt("Cash", coins);
                SetString("DCOwned", "True");
            }
        }
        else
        {
            if (DCOwned == "False")
            {
                SetString("NotEnoughCoinsForDC", "True");
            }
        }
    }

    //this function retrieves the value stored under the specified keyname in the playerprefs dictionary
    public int GetInt(string Keyname)
    {
        return PlayerPrefs.GetInt(Keyname);
    }

    //this function retrieves the value stored under the specified keyname in the playerprefs dictionary
    public string GetString(string Keyname)
    {
        return PlayerPrefs.GetString(Keyname);
    }

    //this function stores the specified value under the specified keyname in the playerprefs dictionary
    public void SetString(string Keyname, string Value)
    {
        PlayerPrefs.SetString(Keyname, Value);
    }

    //this function stores the specified value under the specified keyname in the playerprefs dictionary
    public void SetInt(string Keyname, int Value)
    {
        PlayerPrefs.SetInt(Keyname, Value);
    }
}
