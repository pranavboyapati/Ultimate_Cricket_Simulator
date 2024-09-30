//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CashUpdate : MonoBehaviour
{
    //this function is called once per frame update
    //this function displays the amount of cash the user has
    public void Update()
    {
        int cash = GetInt("Cash");
        GetComponent<UnityEngine.UI.Text>().text = "Cash: " + cash;
    }

    //this function retrieves the value stored under the specified keyname in the playerprefs dictionary
    public int GetInt(string keyname)
    {
        return PlayerPrefs.GetInt(keyname);
    }
}
