//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;
using System.Threading.Tasks;

public class BowlFirstBall : MonoBehaviour
{
    //initialize variables
    public GameObject bowler;
    public GameObject ball;

    //this function is called once when the page is first loaded
    //this function controls the variable that determines when the ball should be bowled and then resets gameobject positions for the next 
    //ball to be played
    public async void Start()
    {        
        await Task.Delay(5000);

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


        Vector3 CurrentPositionBowler = bowler.transform.position;
        CurrentPositionBowler.x = 0.3f;
        CurrentPositionBowler.y = 0.5f;
        CurrentPositionBowler.z = 6.64f;
        bowler.transform.position = CurrentPositionBowler;

        Vector3 CurrentPositionBall = ball.transform.position;
        CurrentPositionBall.x = 0.6f;
        CurrentPositionBall.y = 0.5f;
        CurrentPositionBall.z = 6.4f;
        ball.transform.position = CurrentPositionBall;

        BowlAnimation.yVelocity = 0.0f;
        BowlAnimation.yVelocityLast = 1.0f;
    }
}
