//import libraries
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextPageButton : MonoBehaviour
{
    //this function loads the second page of the buying and selecting teams pages
    public void NextPage()
    {
        SceneManager.LoadScene("TeamBuying&SelectingScene2");
    }
}
