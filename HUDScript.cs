using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDScript : MonoBehaviour {
    float playerScore = 0;
    private GUIStyle guiStyle = new GUIStyle();
	// Update is called once per frame
	void Update () {
        playerScore += Time.deltaTime*2;
	}

    public void IncreaseScore(int amount)
    {
        playerScore += amount;
    }
    void OnDisable()
    {
        PlayerPrefs.SetInt("Score", (int)playerScore);
    }
    void OnGUI()
    {
        guiStyle.fontSize = 40;
        GUI.Label(new Rect(20,20,200,120),"Score: " + (int)(playerScore + 0),guiStyle);
    }
}
