//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BowlAnimation : MonoBehaviour
{
    //initialize variables
    public GameObject bowler;
    public GameObject ball;
    public static float yVelocity;
    public static float yVelocityLast = 1.0f;

    //this function is called once per frame update
    //this function controls the movement of the ball once it is bowled
    public void Update()
    {
        string bowlType = GetString("BowlType");

        if (bowlType == "Fast")
        {
            Vector3 CurrentPosition = ball.transform.position;
            if (CurrentPosition.z > 1.96f)
            {
                bowler.transform.Translate(Vector3.forward * 3.0f * Time.deltaTime);
                ball.transform.Translate(Vector3.back * 3.0f * Time.deltaTime, Space.World);
            }

            else if (CurrentPosition.z > -1.6f)
            {
                ball.transform.Translate(0.0f, yVelocity * Time.deltaTime, 5.5f * -1.0f * Time.deltaTime, Space.World);
                yVelocity -= (2.386851407f * Time.deltaTime);
            }

            else if (CurrentPosition.z > -3.5f)
            {
                ball.transform.Translate(0.0f, yVelocityLast * Time.deltaTime, 2.65f * -1.0f * Time.deltaTime, Space.World);
                yVelocityLast -= (0.8441828255f * Time.deltaTime);
            }
        }

        else if (bowlType == "Spin")
        {
            Vector3 CurrentPosition = ball.transform.position;
            if (CurrentPosition.z > 1.96f)
            {
                bowler.transform.Translate(Vector3.forward * 3.0f * Time.deltaTime);
                ball.transform.Translate(Vector3.back * 3.0f * Time.deltaTime, Space.World);
            }

            else if (CurrentPosition.z > -1.6f)
            {
                ball.transform.Translate(0.0f, yVelocity * Time.deltaTime, 5.5f * -1.0f * Time.deltaTime, Space.World);
                yVelocity -= (2.386851407f * Time.deltaTime);
            }

            else if (CurrentPosition.z > -3.5f)
            {
                ball.transform.Translate(-0.4f * Time.deltaTime, yVelocityLast * Time.deltaTime, 2.65f * -1.0f * Time.deltaTime, Space.World);
                yVelocityLast -= (0.8441828255f * Time.deltaTime);
            }
        }
    }

    //this function retreieves the value stored under the specified keyname in the playerprefs dictionary
    public string GetString(string keyname)
    {
        return PlayerPrefs.GetString(keyname);
    }
}