//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsWon : MonoBehaviour
{
    //initialize variables
    public int RemainingBalls;
    public int coinsWon;
    public int currentCash;

    //this function is called once when the page is first loaded
    //this function calculates the amount of cash the player won from the game
    public void Start()
    {
        RemainingBalls = GetInt("RemainingBalls");
        currentCash = GetInt("Cash");
        coinsWon = RemainingBalls * 50000;
        currentCash += coinsWon;
        PlayerPrefs.SetInt("Cash", currentCash);
        GetComponent<UnityEngine.UI.Text>().text = "Cash Won: $" + coinsWon;
    }

    //this function retrieves the value stored under the specified keyname in the playerprefs dictionary
    public int GetInt(string Keyname)
    {
        return PlayerPrefs.GetInt(Keyname);
    }
}
