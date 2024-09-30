//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;

public class BallRoll : MonoBehaviour
{
    //initialize variables
    public GameObject cricketBall;

    //this function is called once per frame update
    //this function controls the ball rolling motion once it is hit by the batter
    public void Update()
    {
        string BallRollShort = GetString("BallRollShort");
        if (BallRollShort == "True")
        {
            float RotateAmountShort = ((Random.Range(0.0f, 90.0f)) - 45.0f);
            cricketBall.transform.Rotate(0, RotateAmountShort, 0, Space.Self);
            cricketBall.transform.Translate(Vector3.forward * Time.deltaTime * 1.5f);
        }

        string BallRollLong = GetString("BallRollFar");
        if (BallRollLong == "True")
        {
            float RotateAmountLong = ((Random.Range(0.0f, 90.0f)) - 45.0f);
            cricketBall.transform.Rotate(0, RotateAmountLong, 0, Space.Self);
            cricketBall.transform.Translate(Vector3.forward * Time.deltaTime * 3.0f);
        }
    }

    //this function retrieves the value stored under the specified keyname in the playerprefs dictionary
    public string GetString(string keyname)
    {
        return PlayerPrefs.GetString(keyname);
    }
}
