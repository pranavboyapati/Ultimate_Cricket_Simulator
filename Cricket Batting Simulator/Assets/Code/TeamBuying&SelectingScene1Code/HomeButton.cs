//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeButton : MonoBehaviour
{
    //this function loads the home page
    public void Home()
    {
        SceneManager.LoadScene("MainMenuScene");
    }
}
