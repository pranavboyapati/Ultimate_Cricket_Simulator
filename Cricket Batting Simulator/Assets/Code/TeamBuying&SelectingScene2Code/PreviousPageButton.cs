//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PreviousPageButton : MonoBehaviour
{
    //this function loads the first page of buying and selecting a team
    public void PreviousPage()
    {
        SceneManager.LoadScene("TeamBuying&SelectingScene1");
    }
}
