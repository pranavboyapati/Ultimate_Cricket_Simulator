//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;
using System.Threading.Tasks;

public class Bowl : MonoBehaviour
{
    //initialize variables
    public static GameObject bowler;
    public static GameObject ball;

    //this function controls the variable that determines when the ball should be bowled
    public static async void BowlBall()
    {
        int bowlType = Random.Range(1, 3);

        if (bowlType == 1)
        {
            PlayerPrefs.SetString("BowlType", "Fast");
            await Task.Delay(4500);
            PlayerPrefs.SetString("BowlType", "");
        }
        else if (bowlType == 2)
        {
            PlayerPrefs.SetString("BowlType", "Spin");
            await Task.Delay(4500);
            PlayerPrefs.SetString("BowlType", "");
        }
    }
}
