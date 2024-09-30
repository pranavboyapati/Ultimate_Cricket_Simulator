//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Random;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class HitButton : MonoBehaviour
{
    //initialize variables
    public GameObject bat;
    public GameObject bowler;
    public GameObject ball;

    //this function controls the hitting operation by rolling the ball, determining the number of runs for this ball,
    //updating scores and balls remaining, and resetting the players and ball for the next ball to be played
    public async void Hit()
    {
        
        int whetherBallHit = Random.Range(1, 101);
        if (whetherBallHit <= 94)
        {
            int runsToScore = Random.Range(1, 101);

            if(runsToScore <= 13)
            {
                SetInt("PreviousBallRuns", 1);
            
                int currentScore = GetInt("PlayerScore");
                currentScore += 1;
                SetInt("PlayerScore", currentScore);
            }
            else if (runsToScore > 13 && runsToScore <= 58)
            {
                SetInt("PreviousBallRuns", 2);
            
                int currentScore = GetInt("PlayerScore");
                currentScore += 2;
                SetInt("PlayerScore", currentScore);
            }
            else if (runsToScore > 58 && runsToScore <= 65)
            {
                SetInt("PreviousBallRuns", 3);
            
                int currentScore = GetInt("PlayerScore");
                currentScore += 3;
                SetInt("PlayerScore", currentScore);
            }
            else if(runsToScore > 65 && runsToScore <= 90)
            {
                SetInt("PreviousBallRuns", 4);
            
                int currentScore = GetInt("PlayerScore");
                currentScore += 4;
                SetInt("PlayerScore", currentScore);
            }
            else if(runsToScore > 90 && runsToScore <= 100)
            {
                SetInt("PreviousBallRuns", 6);
            
                int currentScore = GetInt("PlayerScore");
                currentScore += 6;
                SetInt("PlayerScore", currentScore);
            }

            PlayerPrefs.SetString("BallRollFar", "True");
            bat.transform.Rotate(-90.0f, 0.0f, 0.0f, Space.Self);
            await Task.Delay(3000);
            PlayerPrefs.SetString("BallRollFar", "False");
            bat.transform.Rotate(90.0f, 0.0f, 0.0f, Space.Self);
        }
        else if (whetherBallHit > 94 && whetherBallHit <= 98)
        {
            SetInt("PreviousBallRuns", 0);
            
            int currentScore = GetInt("PlayerScore");
            currentScore += 0;
            SetInt("PlayerScore", currentScore);
        }
        else if (whetherBallHit == 99 || whetherBallHit == 100)
        {
            SceneManager.LoadScene("ResultsScene");
        }

        int ballsRemaining = GetInt("RemainingBalls");
        ballsRemaining -= 1;
        SetInt("RemainingBalls", ballsRemaining);


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

        await Task.Delay(3000);

        Bowl.BowlBall();
    }

    //this function stores the specified value under the specified keyname in the playerprefs dictionary
    public void SetInt(string keyname, int value)
    {
        PlayerPrefs.SetInt(keyname, value);
    }

    //this function retreieves the value stored under the specified keyname in the playerprefs dictionary
    public int GetInt(string keyname)
    {
        return PlayerPrefs.GetInt(keyname);
    }
}
