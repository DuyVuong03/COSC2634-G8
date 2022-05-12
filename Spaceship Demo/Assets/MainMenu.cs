using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void ExitButton() {
        Application.Quit();
        Debug.Log("Game Exit");
    }

    public void OpenGame() {
        SceneManager.LoadScene("Play");
    }
}

// *Title: MAIN MENU in Unity - Unity UI tutorial 
// *Author: Coco Code 
// *Date:  Oct 19, 2020 
// * Code version: V1 
// *Availability: https://www.youtube.com/watch?v=RsgiYqLID-U (Accessed 10 May 2022)