//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePlayerPrefs : MonoBehaviour
{
    //this function is called once when the page is first loaded
    //this function ensures all variables are properly created in the playerprefs dictionary
    public void Start()
    {
        if (PlayerPrefs.HasKey("NotEnoughCoinsForDC") == false)
        {
            SetString("NotEnoughCoinsForDC", "False");
        }
        if (PlayerPrefs.HasKey("NotEnoughCoinsForRCB") == false)
        {
            SetString("NotEnoughCoinsForRCB", "False");
        }
        if (PlayerPrefs.HasKey("NotEnoughCoinsForRR") == false)
        {
            SetString("NotEnoughCoinsForRR", "False");
        }
        if (PlayerPrefs.HasKey("NotEnoughCoinsForKKR") == false)
        {
            SetString("NotEnoughCoinsForKKR", "False");
        }
        if (PlayerPrefs.HasKey("NotEnoughCoinsForGT") == false)
        {
            SetString("NotEnoughCoinsForGT", "False");
        }
        if (PlayerPrefs.HasKey("NotEnoughCoinsForCSK") == false)
        {
            SetString("NotEnoughCoinsForCSK", "False");
        }
        if (PlayerPrefs.HasKey("NotEnoughCoinsForMI") == false)
        {
            SetString("NotEnoughCoinsForMI", "False");
        }
        if (PlayerPrefs.HasKey("NotEnoughCoinsForPK") == false)
        {
            SetString("NotEnoughCoinsForPK", "False");
        }
        if (PlayerPrefs.HasKey("NotEnoughCoinsForLSG") == false)
        {
            SetString("NotEnoughCoinsForLSG", "False");
        }
        if (PlayerPrefs.HasKey("NotEnoughCoinsForSRH") == false)
        {
            SetString("NotEnoughCoinsForSRH", "False");
        }
        if (PlayerPrefs.HasKey("DCOwned") == false)
        {
            SetString("DCOwned", "False");
        }
        if (PlayerPrefs.HasKey("RCBOwned") == false)
        {
            SetString("RCBOwned", "False");
        }
        if (PlayerPrefs.HasKey("RROwned") == false)
        {
            SetString("RROwned", "False");
        }
        if (PlayerPrefs.HasKey("KKROwned") == false)
        {
            SetString("KKROwned", "False");
        }
        if (PlayerPrefs.HasKey("GTOwned") == false)
        {
            SetString("GTOwned", "False");
        }
        if (PlayerPrefs.HasKey("CSKOwned") == false)
        {
            SetString("CSKOwned", "False");
        }
        if (PlayerPrefs.HasKey("MIOwned") == false)
        {
            SetString("MIOwned", "False");
        }
        if (PlayerPrefs.HasKey("PKOwned") == false)
        {
            SetString("PKOwned", "False");
        }
        if (PlayerPrefs.HasKey("LSGOwned") == false)
        {
            SetString("LSGOwned", "False");
        }
        if (PlayerPrefs.HasKey("SRHOwned") == false)
        {
            SetString("SRHOwned", "False");
        }
        if (PlayerPrefs.HasKey("SelectedTeam") == false)
        {
            SetString("SelectedTeam", "");
        }
        if (PlayerPrefs.HasKey("BallRollFar") == false)
        {
            SetString("BallRollFar", "False");
        }
        if (PlayerPrefs.HasKey("BallRollShort") == false)
        {
            SetString("BallRollShort", "False");
        }
        if (PlayerPrefs.HasKey("BowlType") == false)
        {
            SetString("BowlType", "");
        }

        if (PlayerPrefs.HasKey("Cash") == false)
        {
            SetInt("Cash", 10000000);
        }
        if (PlayerPrefs.HasKey("RemainingBalls") == false)
        {
            SetInt("RemainingBalls", 0);
        }
        if (PlayerPrefs.HasKey("ComputerScore") == false)
        {
            SetInt("ComputerScore", 0);
        }
        if (PlayerPrefs.HasKey("PlayerScore") == false)
        {
            SetInt("PlayerScore", 0);
        }
        if (PlayerPrefs.HasKey("PreviousBallRuns") == false)
        {
            SetInt("PreviousBallRuns", 0);
        }
    } 

    //this function stores the specified value under the specified keyname in the playerprefs dictionary
    public void SetInt(string keyname, int value)
    {
        PlayerPrefs.SetInt(keyname, value);
    }

    //this function stores the specified value under the specified keyname in the playerprefs dictionary
    public void SetString(string keyname, string value)
    {
        PlayerPrefs.SetString(keyname, value);
    }
}
