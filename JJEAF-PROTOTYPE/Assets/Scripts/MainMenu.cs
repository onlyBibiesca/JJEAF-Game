using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    [SerializeField] public GameObject buttons;

    //Loads into the intro
    public void StartPlaying()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Switching to main gameplay");
    }

    //option menu
    public void Options()
    {
        //There will be music, effects, and master volume
    }

    //obviously quits game
    public void QuitGame()
    { 
        Application.Quit();
        Debug.Log("Quit");
    }
}
