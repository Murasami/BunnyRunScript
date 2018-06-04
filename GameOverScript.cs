using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScript : MonoBehaviour {
    int score = 0;
    void Start()
    {
        score = PlayerPrefs.GetInt("Score");
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2 - 40,50,80,30),"GAME OVER");
        GUI.Label(new Rect(Screen.width / 2 - 40, 300, 80, 30),"Score " + score);
        if(GUI.Button(new Rect(Screen.width / 2 - 40, 350, 60, 30), "Retry?"))
        {
            Application.LoadLevel(1);
        }
        if (GUI.Button(new Rect(Screen.width / 2 +60, 350, 60, 30), "Quit?"))
        {
            Application.Quit();
        }
        if (GUI.Button(new Rect(Screen.width / 2 - 170, 350, 90, 30), "Main Menu"))
        {
            Application.LoadLevel(0);
        }
    }
}
